namespace Pokemon_Battle_Simulator;

public class Charmander
{
    public string Name = "";
    public string Strength = "";
    public string Weakness = "";

    public Charmander(string nickname, string strength, string weakness)
    {
        Console.WriteLine(GetType().Name);
        this.Name = nickname;
        this.Strength = strength;
        this.Weakness = weakness;
    }

    public string DoBattleCry()
    {
        return $"{Name.ToUpper()}!!!!";
    }
}