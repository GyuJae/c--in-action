using System.Drawing;

namespace CSharpActions.FactoryMethod;

public class WhiteShipFactory : IShipFactory
{
    public Ship CreateShip()
    {
        return new Ship
        {
            Name = "White Ship",
            Color = "#fff",
            Logo = "white-ship.png"
        };
    }
}