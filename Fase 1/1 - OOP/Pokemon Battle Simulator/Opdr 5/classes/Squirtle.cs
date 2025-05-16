namespace Pokemon_Battle_Simulator;

public class Squirtle : Pokemon
{
    string Name;
    public Squirtle(string name) : base(name: name, strength: PokemonTypes.WATER, weakness: PokemonTypes.GRASS)
    {
        Name = name;
    }
    public override void DoBattleCry()
    {
        Console.WriteLine($"{Name} uses Battle Cry!\n{Name.ToUpper()}!!!!");
    }
}