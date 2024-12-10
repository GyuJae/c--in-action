namespace CSharpActions.Builder;

public class DetailPlan(int day, string plan)
{
    public int Day { get; } = day;
    public string Plan { get; } = plan;
    
    public override string ToString()
    {
        return $"Day: {Day}, Plan: {Plan}";
    }
}