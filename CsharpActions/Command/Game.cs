namespace CSharpActions.Command;

public class Game(bool isStarted)
{
    private bool _isStarted = isStarted;

    public void Start()
    {
        _isStarted = true;
    }

    public void Stop()
    {
        _isStarted = false;
    }

    public bool IsStarted()
    {
        return _isStarted;
    }
}