namespace Pokemon_Battle_Simulator;

public class Bulbasaur : Pokemon
{
    string Name;
    public Bulbasaur(string name) : base(name: name, strength: PokemonTypes.GRASS, weakness: PokemonTypes.FIRE)
    {
        Name = name;
    }
    public override void DoBattleCry()
    {
        Console.WriteLine($"{Name} uses Battle Cry!\n{Name.ToUpper()}!!!!");
    }
}