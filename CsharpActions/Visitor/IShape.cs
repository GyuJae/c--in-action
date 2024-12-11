namespace CSharpActions.Visitor;

public interface IShape
{
    string Accept(IDevice device);
}