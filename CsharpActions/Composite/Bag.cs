namespace CSharpActions.Composite;

public class Bag: IComponent
{
    private readonly List<IComponent> _components = [];

    public void Add(IComponent component)
    {
        this._components.Add(component);
    }
    
    public int GetPrice()
    {
        return this._components.Sum(component => component.GetPrice());
    }
}