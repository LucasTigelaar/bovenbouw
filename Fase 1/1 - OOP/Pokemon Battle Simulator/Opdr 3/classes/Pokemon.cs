namespace Pokemon_Battle_Simulator;

public abstract class Pokemon
{
    public string Name = "";
    public string Strength = "";
    public string Weakness = "";
    public Pokemon(string name, string strength, string weakness)
    {
        Name = name;
        Strength = strength;
        Weakness = weakness;
    }
    public abstract void DoBattleCry();
}