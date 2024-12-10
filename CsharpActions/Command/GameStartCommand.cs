namespace CSharpActions.Command;

public class GameStartCommand(Game game) : ICommand
{
    private readonly Game _game = game;

    public void Execute()
    {
        _game.Start();
    }

    public void Undo()
    {
        _game.Stop();
    }
}