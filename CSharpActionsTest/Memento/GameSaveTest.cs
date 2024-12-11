using CSharpActions.Memento;
using JetBrains.Annotations;

namespace CSharpActionsTest.Memento;

[TestSubject(typeof(GameSave))]
public class GameSaveTest
{
    [Fact(DisplayName = "(Memento) 게임을 저장할 수 있습니다.")]
    public void Game_Save_TEST()
    {
        var game = new Game(0, 0);
        game.SetBlueTeamScore(10);
        game.SetRedTeamScore(15);
        var save = game.Save();

        game.SetBlueTeamScore(15);
        game.SetRedTeamScore(20);

        game.Restore(save);

        Assert.Equal(10, game.BlueTeamScore);
        Assert.Equal(15, game.RedTeamScore);
    }
}