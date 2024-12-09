namespace CSharpActions.AbstractFactory;

public class WhiteShipPartsFactory: IShipPartsFactory
{
    public IAnchor CreateAnchor()
    {
        return new WhiteAnchor();
    }

    public IWheel CreateWheel()
    {
        return new WhiteWheel();
    }
}