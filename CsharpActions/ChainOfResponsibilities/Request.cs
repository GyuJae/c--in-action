namespace CSharpActions.ChainOfResponsibilities;

public class Request(string body)
{
    public string Body { get; private set; } = body;

    public void SetBody(string body)
    {
        Body = body;
    }
}