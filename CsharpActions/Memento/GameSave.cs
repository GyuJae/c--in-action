namespace CSharpActions.Memento;

public class GameSave(int blueTeamScore, int redTeamScore)
{
    public int BlueTeamScore { get; } = blueTeamScore;
    public int RedTeamScore { get; } = redTeamScore;
}