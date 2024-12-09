namespace CSharpActions.FactoryMethod;

public class Ship
{
    public string Name { get; set; }
    public string Color { get; set; }   
    public string Logo { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Color} - {Logo}";
    }
}