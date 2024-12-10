using System.Net;
using System.Net.Mail;

namespace CSharpActions.Facade;

public class EmailSender(EmailSettings emailSettings)
{
    private readonly EmailSettings _emailSettings = emailSettings;

    public string SendEmail(EmailMessage emailMessage)
    {
        return "이메일 전송이 완료되었습니다.";
    }
}