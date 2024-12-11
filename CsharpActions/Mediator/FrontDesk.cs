namespace CSharpActions.Mediator;

public class FrontDesk
{
    private readonly CleaningService _cleaningService = new();
    private readonly Restaurant _restaurant = new();

    public string Dinner(Guest guest, DateTime date)
    {
        return _restaurant.Dinner(guest.Id, date);
    }

    public int GetRoomNumberFor(int guestId)
    {
        return 1111;
    }

    public string GetTowels(Guest guest, int numberOfTowels)
    {
        return _cleaningService.GetTowels(guest.Id, numberOfTowels);
    }
}