using CSharpActions.ChainOfResponsibilities;
using JetBrains.Annotations;
using Moq;

namespace CSharpActionsTest.ChainOfResponsibilities;

[TestSubject(typeof(RequestHandler))]
public class RequestHandlerTest
{
    [Fact(DisplayName = "(Chain Of Responsibilities) Request를 체인으로 연결할 수 있습니다.)")]
    public void Chain_Handler_Test()
    {
        var request = new Request("requset1");
        var mockAuthService = new Mock<IAuthService>();
        var mockLoggingService = new Mock<ILoggerService>();
        var mockPrintService = new Mock<IPrintService>();
        var chain = new AuthRequestHandler(
            new LoggingRequestHandler(
                new PrintRequestHandler(
                    null,
                    mockPrintService.Object
                ),
                mockLoggingService.Object
            ),
            mockAuthService.Object
        );

        chain.Handle(request);

        mockAuthService.Verify(obj => obj.Login(), Times.Once());
        mockLoggingService.Verify(obj => obj.Log(), Times.Once());
        mockPrintService.Verify(obj => obj.Print(), Times.Once());
    }
}