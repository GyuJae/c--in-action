namespace CSharpActions.Observer;

public class User(string name) : ISubscriber
{
    public string Name { get; } = name;


    public string HandleMessage(string message)
    {
        return message;
    }
}