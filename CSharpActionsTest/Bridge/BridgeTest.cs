using CSharpActions.Bridge;
using JetBrains.Annotations;

namespace CSharpActionsTest.Bridge;

[TestSubject(typeof(Akali))]
public class BridgeTest
{

    [Fact(DisplayName = "(Bridge) Akali 챔피언에 다영한 스킨을 넣을 수 있습니다.")]
    public void Akali_Test()
    {
        IChampion kdaAkali = new Akali(new KDA());
        IChampion poolPartyAkali = new Akali(new PoolParty());
        
        Assert.Equal("KDA Akali move", kdaAkali.Move());
        Assert.Equal("PoolParty Akali move", poolPartyAkali.Move());
        Assert.Equal("KDA Akali skill q", kdaAkali.SkillQ());
        Assert.Equal("PoolParty Akali skill q", poolPartyAkali.SkillQ());
    }
    
    [Fact(DisplayName = "(Bridge) Ahri 챔피언에 다영한 스킨을 넣을 수 있습니다.")]
    public void Ahri_Test()
    {
        IChampion kdaAhri = new Ahri(new KDA());
        IChampion poolPartyAhri = new Ahri(new PoolParty());
        
        Assert.Equal("KDA Ahri move", kdaAhri.Move());
        Assert.Equal("PoolParty Ahri move", poolPartyAhri.Move());
        Assert.Equal("KDA Ahri skill q", kdaAhri.SkillQ());
        Assert.Equal("PoolParty Ahri skill q", poolPartyAhri.SkillQ());
    }
}