using CSharpActions.Proxy;
using JetBrains.Annotations;
using Moq;

namespace CSharpActionsTest.Proxy;

[TestSubject(typeof(GameServiceProxy))]
public class GameServiceProxyTest
{
    [Fact (DisplayName = "(Proxy) 게임 시작전에 로그를 남길 수 있습니다.")]
    public void Game_Service_Proxy_Test()
    {
        var gameService = new DefaultGameService();
        var logger = new Mock<ILogger>();
        var proxy = new GameServiceProxy(gameService, logger.Object);

        var message = proxy.Start();
        
        Assert.Equal("게임을 시작합니다.", message);
        logger.Verify(obj => obj.Log(It.IsAny<string>()), Times.Once());
    }
}
