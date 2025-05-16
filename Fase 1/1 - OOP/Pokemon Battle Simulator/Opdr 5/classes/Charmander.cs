namespace Pokemon_Battle_Simulator;

public class Charmander : Pokemon
{
    string Name;
    public Charmander(string name) : base(name: name, strength: PokemonTypes.FIRE, weakness: PokemonTypes.WATER)
    {
        Name = name;
    }
    public override void DoBattleCry()
    {
        Console.WriteLine($"{Name} uses Battle Cry!\n{Name.ToUpper()}!!!!");
    }
}