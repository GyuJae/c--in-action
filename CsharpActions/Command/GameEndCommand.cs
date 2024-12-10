namespace CSharpActions.Command;

public class GameEndCommand(Game game) : ICommand
{
    private readonly Game _game = game;

    public void Execute()
    {
        _game.Stop();
    }

    public void Undo()
    {
        _game.Start();
    }
}