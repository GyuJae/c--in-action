using CSharpActions.Visitor;
using JetBrains.Annotations;

namespace CSharpActionsTest.Visitor;

[TestSubject(typeof(Phone))]
public class PhoneTest
{
    [Fact(DisplayName = "(Visitor) Phone은 원과 직사각형을 그릴 수 있습니다.")]
    public void PHONE_PRINT_TEST()
    {
        var rectangle = new Rectangle();
        var circle = new Circle();
        var phone = new Phone();

        Assert.Equal("circle print by phone", phone.Print(circle));
        Assert.Equal("rectangle print by phone", phone.Print(rectangle));
    }
}