namespace CSharpActions.Command;

public class LightOnCommand(Light light) : ICommand
{
    private readonly Light _light = light;


    public void Execute()
    {
        _light.On();
    }

    public void Undo()
    {
        _light.Off();
    }
}