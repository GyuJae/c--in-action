namespace CSharpActions.Command;

public class LightOffCommand(Light light) : ICommand
{
    private readonly Light _light = light;

    public void Execute()
    {
        _light.Off();
    }

    public void Undo()
    {
        _light.On();
    }
}