namespace CSharpActions.AbstractFactory;

public interface IShipPartsFactory
{
    IAnchor CreateAnchor();
    IWheel CreateWheel();
}