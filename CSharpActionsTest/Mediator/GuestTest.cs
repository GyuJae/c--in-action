using CSharpActions.Mediator;
using JetBrains.Annotations;

namespace CSharpActionsTest.Mediator;

[TestSubject(typeof(Guest))]
public class GuestTest
{
    [Fact(DisplayName = "(Mediator) 저녁식사 시간을 결정할 수 있습니다.")]
    public void Dinner_TEST()
    {
        var guest = new Guest
        {
            Id = 1
        };
        var dinnerTime = new DateTime(2024, 10, 9);

        var result = guest.Dinner(dinnerTime);

        Assert.Equal("Dinner arranged for Guest 1 at 2024-10-09", result);
    }

    [Fact(DisplayName = "(Mediator) 수건을 받아올 수 있습니다.")]
    public void Get_Towels_TEST()
    {
        var guest = new Guest
        {
            Id = 1
        };

        var result = guest.GetTowels(10);

        Assert.Equal("Provide 10 towels to clean 1111", result);
    }
}