namespace CSharpActions.Proxy;

public class DefaultGameService: IGameService
{
    public string Start()
    {
        return "게임을 시작합니다.";
    }
}