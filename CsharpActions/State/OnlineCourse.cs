namespace CSharpActions.State;

public class OnlineCourse
{
    private IState _state = new Draft();

    public List<Student> Students { get; } = [];

    public List<string> Reviews { get; } = [];

    public void AddStudent(Student student)
    {
        _state.AddStudent(student, this);
    }

    public void AddReview(string review, Student student)
    {
        _state.AddReview(review, student, this);
    }

    public void ChangeState(IState state)
    {
        _state = state;
    }

    public IState GetState()
    {
        return _state;
    }
}