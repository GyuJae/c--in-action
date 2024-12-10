namespace CSharpActions.Composite;

public class Item(string name, int price) : IComponent
{
    private readonly string _name = name;
    private readonly int _price = price;

    public int GetPrice()
    {
        return this._price;
    }
}