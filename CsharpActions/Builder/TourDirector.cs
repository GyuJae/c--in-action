namespace CSharpActions.Builder;

public class TourDirector(ITourPlanBuilder tourPlanBuilder)
{
    private readonly ITourPlanBuilder _tourPlanBuilder = tourPlanBuilder;
    
    public TourPlan CancunTrip()
    {
        return _tourPlanBuilder.Title("칸쿤 여행")
            .NightsAndDays(2, 3)
            .StartDate(new DateTime(2020, 12, 9))
            .WhereToStay("리조트")
            .AddPlan(0, "체크인하고 짐 풀기")
            .AddPlan(0, "저녁 식사")
            .GetPlan();
    }

    public TourPlan LongBeachTrip()
    {
        return _tourPlanBuilder.Title("롱비치")
            .StartDate(new DateTime(2021, 7, 15))
            .GetPlan();
    }
}