namespace CSharpActions.Bridge;

public class DefaultChampion(ISkin skin, string name) : IChampion
{
    private readonly ISkin _skin = skin;
    private readonly string _name = name;

    public string Move()
    {
        return $"{_skin.GetName()} {_name} move";
    }

    public string SkillQ()
    {
        return $"{_skin.GetName()} {_name} skill q";
    }

    public string SkillW()
    {
        return $"{_skin.GetName()} {_name} skill w";    
    }

    public string SkillE()
    {
        return $"{_skin.GetName()} {_name} skill E";    
    }

    public string SkillR()
    {
        return $"{_skin.GetName()} {_name} skill R";   
    }
}