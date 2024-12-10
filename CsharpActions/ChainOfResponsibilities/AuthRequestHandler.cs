namespace CSharpActions.ChainOfResponsibilities;

public class AuthRequestHandler(RequestHandler? nextHandler, IAuthService authService) : RequestHandler(nextHandler)
{
    private readonly IAuthService _authService = authService;

    public override void Handle(Request request)
    {
        _authService.Login();
        base.Handle(request);
    }
}