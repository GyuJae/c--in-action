using CSharpActions.Composite;
using JetBrains.Annotations;

namespace CSharpActionsTest.Composite;

[TestSubject(typeof(Print))]
public class PrintTest
{

    [Fact(DisplayName = "(Composite) IComponent로 구현된 객체의 가격을 보여줄 수 있습니다.")]
    public void PrintPrice_Test()
    {
        var doranBlade = new Item("도란검", 450);
        var healPotion = new Item("체력 물약", 50);

        var bag = new Bag();
        bag.Add(doranBlade);
        bag.Add(healPotion);

        var print = new Print();
        
        Assert.Equal("Price: 450", print.PrintPrice(doranBlade));
        Assert.Equal("Price: 50", print.PrintPrice(healPotion));
        Assert.Equal("Price: 500", print.PrintPrice(bag));
    }
}