namespace CSharpActions.Visitor;

public class Phone : IDevice
{
    public string Print(Circle circle)
    {
        return "circle print by phone";
    }

    public string Print(Rectangle rectangle)
    {
        return "rectangle print by phone";
    }
}