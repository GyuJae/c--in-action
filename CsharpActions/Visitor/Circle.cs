namespace CSharpActions.Visitor;

public class Circle : IShape
{
    public string Accept(IDevice device)
    {
        return device.Print(this);
    }
}