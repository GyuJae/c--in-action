namespace CSharpActions.Builder;

public interface ITourPlanBuilder
{
   ITourPlanBuilder NightsAndDays(int nights, int days);
   ITourPlanBuilder Title(string title);
   ITourPlanBuilder StartDate(DateTime startDate);
   ITourPlanBuilder WhereToStay(string whereToStay);
   ITourPlanBuilder AddPlan(int day, string plan);
   TourPlan GetPlan();
}