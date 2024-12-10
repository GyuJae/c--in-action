namespace CSharpActions.ChainOfResponsibilities;

public class LoggingRequestHandler(RequestHandler? nextHandler, ILoggerService loggerService) : RequestHandler(nextHandler)
{
    private readonly ILoggerService _loggerService = loggerService;

    public override void Handle(Request request)
    {
        _loggerService.Log();
        base.Handle(request);
    }
}