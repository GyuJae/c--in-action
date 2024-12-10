using CSharpActions.Command;
using JetBrains.Annotations;

namespace CSharpActionsTest.Command;

[TestSubject(typeof(Button))]
public class ButtonTest
{
    [Fact(DisplayName = "(Command) Button을 누르면 실행할 수 있습니다.")]
    public void Button_Press_Test()
    {
        var game = new Game(false);
        var button = new Button();

        button.Press(new GameStartCommand(game));

        Assert.True(game.IsStarted());
    }

    [Fact(DisplayName = "(Command) Button을 실행 했던걸 다시 되돌릴 수 있다.")]
    public void Button_Undo_Test()
    {
        var game = new Game(false);
        var button = new Button();
        button.Press(new GameStartCommand(game));

        button.Undo();

        Assert.False(game.IsStarted());
    }

    [Fact(DisplayName = "(Command) 다양한 명령어를 실행할 수 있다.")]
    public void Button_Command_Stack_Test()
    {
        var game = new Game(false);
        var light = new Light(false);
        var button = new Button();

        button.Press(new GameStartCommand(game));
        button.Press(new LightOnCommand(light));

        Assert.True(game.IsStarted());
        Assert.True(light.IsOn());
    }
}