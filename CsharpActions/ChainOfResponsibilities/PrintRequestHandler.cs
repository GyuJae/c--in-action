namespace CSharpActions.ChainOfResponsibilities;

public class PrintRequestHandler(RequestHandler? nextHandler, IPrintService printService) : RequestHandler(nextHandler)
{
    private readonly IPrintService _printService = printService;

    public override void Handle(Request request)
    {
        this._printService.Print();
        base.Handle(request);
    }
}