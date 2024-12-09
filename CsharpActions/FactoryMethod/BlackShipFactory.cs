namespace CSharpActions.FactoryMethod;

public class BlackShipFactory: IShipFactory
{
    public Ship CreateShip()
    {
        return new Ship
        {
            Name = "Black Ship",
            Color = "#000",
            Logo = "Black Ship.png"
        };
    }
}