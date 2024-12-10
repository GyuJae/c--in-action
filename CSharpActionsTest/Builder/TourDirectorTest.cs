using CSharpActions.Builder;
using JetBrains.Annotations;

namespace CSharpActionsTest.Builder;

[TestSubject(typeof(TourDirector))]
public class TourDirectorTest
{

    [Fact(DisplayName = "(Builder) 칸쿤 여행 계획을 만들 수 있습니다.")]
    public void TourDirector_Cancun_Trip_Test()
    {
        var director = new TourDirector(new DefaultTourPlanBuilder());

        var cancunTrip = director.CancunTrip();
        
        Assert.Equal("칸쿤 여행", cancunTrip.Title);
        Assert.Equal(2, cancunTrip.Nights);
        Assert.Equal(3, cancunTrip.Days);
        Assert.Equal("리조트", cancunTrip.WhereToStay);
        Assert.Equal(new DateTime(2020, 12, 9), cancunTrip.StartDate);
        Assert.Equal(2, cancunTrip.Plans.Count);
    }
    
 
    [Fact(DisplayName = "(Builder) 롱비치 여행 계획을 만들 수 있습니다.")]
    public void TourDirector_Long_Beach_Trip_Test()
    {
        var director = new TourDirector(new DefaultTourPlanBuilder());

        var longBeachTrip = director.LongBeachTrip();
        
        Assert.Equal("롱비치", longBeachTrip.Title);
        Assert.Equal(new DateTime(2021, 7, 15), longBeachTrip.StartDate);
        Assert.Empty(longBeachTrip.Plans);
    }   
}