namespace CSharpActions.Builder;

public class DefaultTourPlanBuilder: ITourPlanBuilder
{
    private string _title = "";
    private int _nights;
    private int _days;
    private DateTime _startDate;
    private string _whereToStay = "";
    private List<DetailPlan> _plans = [];
    public ITourPlanBuilder NightsAndDays(int nights, int days)
    {
        this._nights = nights;
        this._days = days;
        return this;
    }

    public ITourPlanBuilder Title(string title)
    {
        this._title = title;
        return this;
    }

    public ITourPlanBuilder StartDate(DateTime startDate)
    {
        this._startDate = startDate;
        return this;
    }

    public ITourPlanBuilder WhereToStay(string whereToStay)
    {
        this._whereToStay = whereToStay;
        return this;
    }

    public ITourPlanBuilder AddPlan(int day, string plan)
    {
        this._plans.Add(new DetailPlan(day, plan));
        return this;
    }

    public TourPlan GetPlan()
    {
        return new TourPlan
        {
            Title = _title,
            StartDate = _startDate,
            Nights = _nights,
            Days = _days,
            WhereToStay = _whereToStay,
            Plans = _plans
        };
    }
}