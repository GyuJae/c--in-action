namespace CSharpActions.Mediator;

public class Guest
{
    private readonly FrontDesk _frontDesk = new();
    public int Id { get; set; }

    public string GetTowels(int numberOfTowels)
    {
        return _frontDesk.GetTowels(this, numberOfTowels);
    }

    public string Dinner(DateTime dateTime)
    {
        return _frontDesk.Dinner(this, dateTime);
    }
}