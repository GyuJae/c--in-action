namespace CSharpActions.Composite;

public class Character(Bag bag) : IComponent
{
    private readonly Bag _bag = bag;
    
    public int GetPrice()
    {
        return this._bag.GetPrice();
    }
}