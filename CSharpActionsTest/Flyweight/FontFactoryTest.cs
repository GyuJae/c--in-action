using CSharpActions.Flyweight;
using JetBrains.Annotations;

namespace CSharpActionsTest.Flyweight;

[TestSubject(typeof(FontFactory))]
public class FontFactoryTest
{

    [Fact(DisplayName = "(Flyweight) fontFactory를 통해서 Font를 생성할 수 있습니다.")]
    public void Font_Factory_Test()
    {
        var fontFactory = new FontFactory();
        var c1 = new Character("h", "white", fontFactory.GetFont("nanum:12"));
        var c2 = new Character("e", "black", fontFactory.GetFont("nanum:12"));
        var c3 = new Character("l", "red", fontFactory.GetFont("nanum:12"));
        
        Assert.Equal(c1.GetFont(), c2.GetFont());
        Assert.Equal(c1.GetFont(), c3.GetFont());
    }
}