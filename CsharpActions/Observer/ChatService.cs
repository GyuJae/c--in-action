namespace CSharpActions.Observer;

public class ChatService
{
    private readonly Dictionary<string, List<ISubscriber>> _subscribers = new();

    public void Register(string subject, ISubscriber subscriber)
    {
        if (_subscribers.TryGetValue(subject, out var subscriberOut))
            subscriberOut.Add(subscriber);
        else
            _subscribers[subject] = [subscriber];
    }

    public void Unregister(string subject, ISubscriber subscriber)
    {
        if (_subscribers.TryGetValue(subject, out var subscriber1)) subscriber1.Remove(subscriber);
    }

    public List<string> SendMessage(User user, string subject, string message)
    {
        return !_subscribers.TryGetValue(subject, out var subscribers)
            ? []
            : subscribers.Select(s => s.HandleMessage($"{user.Name}: {message}")).ToList();
    }
}