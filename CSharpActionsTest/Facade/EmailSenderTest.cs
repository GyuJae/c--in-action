using CSharpActions.Facade;
using JetBrains.Annotations;

namespace CSharpActionsTest.Facade;

[TestSubject(typeof(EmailSender))]
public class EmailSenderTest
{

    [Fact(DisplayName = "(Facade) 이메일을 전송할 수 있습니다.")]
    public void Send_Message_Test()
    {
        var settings = new EmailSettings { Host = "127.0.0.1" };
        var sender = new EmailSender(settings);
        var message = new EmailMessage
        {
            From = "gyujae",
            To = "규재",
            Cc = "하위",
            Subject = "공지",
            Text = "내용"
        };
        
        var result = sender.SendEmail(message);
        
        Assert.Equal("이메일 전송이 완료되었습니다.", result);
    }
}