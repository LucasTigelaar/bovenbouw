namespace Pokemon_Battle_Simulator;

public class Pokeball
{
    public bool ContainsPokemon;
    public string Name;
    public Pokemon PokemonInPokeball;
    public Pokeball(int ballCount, bool containsPokemon, Pokemon pokemonInPokeball)
    {
        Name = $"{GetType().Name}_{ballCount}";
        ContainsPokemon = containsPokemon;
        PokemonInPokeball = pokemonInPokeball;
    }

    public Pokemon OpenPokeball()
    {
        ContainsPokemon = false;
        Console.WriteLine($"The pokeball opened and {PokemonInPokeball.GetName()} is released!");
        return PokemonInPokeball;
    }
    public void ClosePokeball()
    {
        ContainsPokemon = true;
        Console.WriteLine($"The pokeball closed and {PokemonInPokeball.GetName()} is returned.");
    }
}