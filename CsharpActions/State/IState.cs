namespace CSharpActions.State;

public interface IState
{
    void AddReview(string review, Student student, OnlineCourse onlineCourse);
    void AddStudent(Student student, OnlineCourse onlineCourse);
}