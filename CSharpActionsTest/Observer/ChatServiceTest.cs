using CSharpActions.Observer;
using JetBrains.Annotations;

namespace CSharpActionsTest.Observer;

[TestSubject(typeof(ChatService))]
public class ChatServiceTest
{
    [Fact(DisplayName = "(Observer) 구독한 사람들에게 알림 메세지를 보낼 수 있습니다.")]
    public void Handle_Message_TEST()
    {
        var chatServer = new ChatService();

        var user1 = new User("gyujae");
        var user2 = new User("iksu");

        chatServer.Register("게임", user1);
        chatServer.Register("게임", user2);

        chatServer.Register("뉴스", user1);

        var gameMessages = chatServer.SendMessage(user1, "게임", "게임 구독한 사람들이 받을 수 있는 메세지 입니다.");
        var newsMessages = chatServer.SendMessage(user1, "뉴스", "뉴스 구독한 사람들이 받을 수 있는 메세지 입니다.");

        Assert.Equal(2, gameMessages.Count);
        Assert.Single(newsMessages);
    }
}