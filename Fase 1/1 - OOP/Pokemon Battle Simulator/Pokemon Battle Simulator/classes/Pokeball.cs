namespace Pokemon_Battle_Simulator;

public class Pokeball
{
    public bool ContainsPokemon;
    public string Name;
    public Charmander CharmanderInPokeball;
    public Pokeball(int ballCount, bool containsPokemon, Charmander charmanderInPokeball)
    {
        Name = $"{GetType().Name}_{ballCount}";
        ContainsPokemon = containsPokemon;
        CharmanderInPokeball = charmanderInPokeball;
    }

    public void OpenPokeball()
    {
        ContainsPokemon = false;
    }
}