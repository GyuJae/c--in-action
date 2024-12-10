namespace CSharpActions.Composite;

public class Print
{
    public string PrintPrice(IComponent component)
    {
        return $"Price: {component.GetPrice()}";
    }
}