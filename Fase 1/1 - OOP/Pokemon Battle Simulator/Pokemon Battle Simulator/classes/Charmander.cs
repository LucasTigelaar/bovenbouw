namespace Pokemon_Battle_Simulator;

public class Charmander
{
    public string Name = "";
    public string Strength = "fire";
    public string Weakness = "water";

    public Charmander(int charCount)
    {
        Name = $"{GetType().Name}_{charCount}";
    }

    public void DoBattleCry()
    {
        Console.WriteLine($"{Name} uses Battle Cry!\n{Name.ToUpper()}!!!!");
    }
}