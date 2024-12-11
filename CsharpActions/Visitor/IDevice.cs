namespace CSharpActions.Visitor;

public interface IDevice
{
    string Print(Circle circle);
    string Print(Rectangle rectangle);
}