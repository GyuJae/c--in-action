using CSharpActions.State;
using JetBrains.Annotations;

namespace CSharpActionsTest.State;

[TestSubject(typeof(OnlineCourse))]
public class OnlineCourseTest
{
    [Fact(DisplayName = "(State) Draft 상태에서는 리뷰를 작성할 수 없습니다.")]
    public void Online_Course_Draft_TEST()
    {
        var onlineCourse = new OnlineCourse();
        var student1 = new Student("gyujae");

        onlineCourse.AddStudent(student1);

        Assert.Throws<InvalidOperationException>(() => onlineCourse.AddReview("리뷰", student1));
    }

    [Fact(DisplayName = "(State) 등록된 학생 수가 두명 이상이면 Private 상태로 볍경됩니다.")]
    public void Online_Course_Private_TEST()
    {
        var onlineCourse = new OnlineCourse();
        var student1 = new Student("gyujae");
        var student2 = new Student("iksu");
        onlineCourse.AddStudent(student1);

        onlineCourse.AddStudent(student2);

        Assert.IsType<Private>(onlineCourse.GetState());
    }
}