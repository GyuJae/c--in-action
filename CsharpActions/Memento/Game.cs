namespace CSharpActions.Memento;

public class Game(int blueTeamScore, int redTeamScore)
{
    public int BlueTeamScore { get; private set; } = blueTeamScore;
    public int RedTeamScore { get; private set; } = redTeamScore;

    public void SetBlueTeamScore(int score)
    {
        BlueTeamScore = score;
    }

    public void SetRedTeamScore(int score)
    {
        RedTeamScore = score;
    }

    public GameSave Save()
    {
        return new GameSave(BlueTeamScore, RedTeamScore);
    }

    public void Restore(GameSave save)
    {
        BlueTeamScore = save.BlueTeamScore;
        RedTeamScore = save.RedTeamScore;
    }
}