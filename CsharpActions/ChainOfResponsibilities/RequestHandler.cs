namespace CSharpActions.ChainOfResponsibilities;

public abstract class RequestHandler(RequestHandler? nextHandler)
{
    private readonly RequestHandler? _nextHandler = nextHandler;

    public virtual void Handle(Request request)
    {
        _nextHandler?.Handle(request);
    }
}