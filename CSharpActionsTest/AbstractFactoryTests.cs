using CSharpActions.AbstractFactory;

namespace CSharpActionsTest;

public class AbstractFactoryTests
{
    [Fact(DisplayName = "Abstract Factory 테스트 입니다. (WhiteShipPartsFactory) ")]
    public void Abstract_Factory_Test()
    {
        IShipPartsFactory basePartsFactory = new WhiteShipPartsFactory();
        IShipFactory whiteShipFactory = new WhiteShipFactory(basePartsFactory);

        Ship ship = whiteShipFactory.CreateShip();
        
        Assert.Equal("White Ship", ship.Name);
        Assert.IsType<WhiteAnchor>(ship.Anchor);
        Assert.IsType<WhiteWheel>(ship.Wheel);
    }
    
    [Fact(DisplayName = "Abstract Factory 테스트 입니다. (WhiteShipProPartsFactory) ")]
    public void Abstract_Factory_Test2()
     {
         IShipPartsFactory proPartsFactory = new WhiteShipProPartsFactory();
         IShipFactory whiteShipFactory = new WhiteShipFactory(proPartsFactory);
 
         Ship ship = whiteShipFactory.CreateShip();
         
         Assert.Equal("White Ship", ship.Name);
         Assert.IsType<WhiteAnchorPro>(ship.Anchor);
         Assert.IsType<WhiteWheelPro>(ship.Wheel);
     }   
}