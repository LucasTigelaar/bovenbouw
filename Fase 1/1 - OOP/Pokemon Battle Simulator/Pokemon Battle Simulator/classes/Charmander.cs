namespace Pokemon_Battle_Simulator;

public class Charmander
{
    public string Name = "";
    public string Strength = "";
    public string Weakness = "";

    public Charmander(int charCount, string strength, string weakness)
    {
        Name = $"{GetType().Name}_{charCount}";
        Strength = strength;
        Weakness = weakness;
    }

    public string DoBattleCry()
    {
        return $"{Name} uses Battle Cry!\n{Name.ToUpper()}!!!!";
    }
}