namespace CSharpActions.Command;

public interface ICommand
{
    void Execute();
    void Undo();
}