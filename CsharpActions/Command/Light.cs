namespace CSharpActions.Command;

public class Light(bool isOn)
{
    private bool _isOn = isOn;

    public void On()
    {
        _isOn = true;
    }

    public void Off()
    {
        _isOn = false;
    }

    public bool IsOn()
    {
        return _isOn;
    }
}