namespace CSharpActions.AbstractFactory;

public class WhiteShipFactory(IShipPartsFactory shipPartsFactory) : IShipFactory
{
    public Ship CreateShip()
    {
        return new Ship
        {
            Name = "White Ship",
            Anchor = shipPartsFactory.CreateAnchor(),
            Wheel = shipPartsFactory.CreateWheel()
        };
    }
}