namespace CSharpActions.State;

public class Draft : IState
{
    public void AddReview(string review, Student student, OnlineCourse onlineCourse)
    {
        throw new InvalidOperationException("드래프트 상태에서는 리뷰를 남길 수 없습니다.");
    }

    public void AddStudent(Student student, OnlineCourse onlineCourse)
    {
        onlineCourse.Students.Add(student);
        if (onlineCourse.Students.Count > 1) onlineCourse.ChangeState(new Private());
    }
}