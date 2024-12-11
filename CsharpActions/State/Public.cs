namespace CSharpActions.State;

public class Public : IState
{
    public void AddReview(string review, Student student, OnlineCourse onlineCourse)
    {
        onlineCourse.Reviews.Add(review);
    }

    public void AddStudent(Student student, OnlineCourse onlineCourse)
    {
        onlineCourse.Students.Add(student);
    }
}