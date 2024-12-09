namespace CSharpActions.AbstractFactory;

public class WhiteShipProPartsFactory: IShipPartsFactory
{
    public IAnchor CreateAnchor()
    {
        return new WhiteAnchorPro();
    }

    public IWheel CreateWheel()
    {
        return new WhiteWheelPro();
    }
}