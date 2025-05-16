namespace Pokemon_Battle_Simulator;

public abstract class Pokemon
{
    string Name;
    PokemonTypes Strength;
    PokemonTypes Weakness;

    public Pokemon(string name, PokemonTypes strength, PokemonTypes weakness)
    {
        Name = name;
        Strength = strength;
        Weakness = weakness;
    }
    public abstract void DoBattleCry();

    public string GetName()
    {
        return Name;
    }
    public PokemonTypes GetStrength()
    {
        return Strength;
    }
    public PokemonTypes GetWeakness()
    {
        return Weakness;
    }
}