namespace CSharpActions.Builder;

public class TourPlan
{
    public required string Title { get; set; }
    public required int Nights { get; set; }
    public required int Days { get; set; }
    public required DateTime StartDate { get; set; }
    public required string WhereToStay { get; set; }
    public List<DetailPlan> Plans { get; set; } = [];
    
    
}