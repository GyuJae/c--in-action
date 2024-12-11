using CSharpActions.Strategy;
using JetBrains.Annotations;

namespace CSharpActionsTest.Strategy;

[TestSubject(typeof(BlueLightRedLight))]
public class BlueLightRedLightTest
{
    [Fact(DisplayName = "(Strategy) 속도를 변경하면서 플레이 할 수 있습니다.")]
    public void Blue_Light_Red_Light_Speed_TEST()
    {
        var game = new BlueLightRedLight();
        var normal = new Normal();
        var faster = new Faster();

        Assert.Equal("무 궁 화 꽃 이", game.BlueLight(normal));
        Assert.Equal("피었습니다.", game.RedLight(faster));
    }
}