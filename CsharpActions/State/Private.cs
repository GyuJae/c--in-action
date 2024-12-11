namespace CSharpActions.State;

public class Private : IState
{
    public void AddReview(string review, Student student, OnlineCourse onlineCourse)
    {
        if (onlineCourse.Students.Contains(student))
            onlineCourse.Reviews.Add(review);
        else
            throw new InvalidOperationException("프라이빗 코스는 수강하는 학생만 리뷰를 남길 수 있습니다,");
    }

    public void AddStudent(Student student, OnlineCourse onlineCourse)
    {
        onlineCourse.AddStudent(student);
    }
}