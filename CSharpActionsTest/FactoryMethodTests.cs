using CSharpActions.FactoryMethod;

namespace CSharpActionsTest;

public class FactoryMethodTests
{
    [Fact(DisplayName = "Factory method 패턴 테스트입니다.")]
    public void Factory_Method_Test()
    {
        IShipFactory whiteShipFactory = new WhiteShipFactory();
        IShipFactory blackShipFactory = new BlackShipFactory();
        
        Ship whiteShip = whiteShipFactory.CreateShip();
        Ship blackShip = blackShipFactory.CreateShip();

        Assert.Equal("White Ship", whiteShip.Name);
        Assert.Equal("Black Ship", blackShip.Name);
    }
}