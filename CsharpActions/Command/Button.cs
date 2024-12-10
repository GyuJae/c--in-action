namespace CSharpActions.Command;

public class Button
{
    private readonly Stack<ICommand> _commands = [];

    public void Press(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Count <= 0) return;
        var command = _commands.Pop();
        command.Undo();
    }
}