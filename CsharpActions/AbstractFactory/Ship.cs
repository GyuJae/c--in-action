namespace CSharpActions.AbstractFactory;

public class Ship 
{
    public string Name { get; set; }
    public IAnchor Anchor { get; set; }
    public IWheel Wheel { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Anchor: {Anchor}, Wheel: {Wheel}"; 
    }
}