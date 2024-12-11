namespace CSharpActions.Visitor;

public class Rectangle : IShape
{
    public string Accept(IDevice device)
    {
        return device.Print(this);
    }
}