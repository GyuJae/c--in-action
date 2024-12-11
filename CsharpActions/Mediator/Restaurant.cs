namespace CSharpActions.Mediator;

public class Restaurant
{
    public string Dinner(int guestId, DateTime dateTime)
    {
        return $"Dinner arranged for Guest {guestId} at {dateTime:yyyy-MM-dd}";
    }
}