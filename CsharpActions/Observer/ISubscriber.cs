namespace CSharpActions.Observer;

public interface ISubscriber
{
    string HandleMessage(string message);
}