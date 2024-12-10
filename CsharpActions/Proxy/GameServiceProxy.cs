namespace CSharpActions.Proxy;

public class GameServiceProxy(IGameService gameService, ILogger logger) : IGameService
{
    private readonly IGameService _gameService = gameService;
    private readonly ILogger _logger = logger;
    
    public string Start()
    {
        this._logger.Log("Starting game service");
        return _gameService.Start();
    }
}