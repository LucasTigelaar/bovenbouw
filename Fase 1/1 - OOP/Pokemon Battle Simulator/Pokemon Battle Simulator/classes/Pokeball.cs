namespace Pokemon_Battle_Simulator;

public class Pokeball
{
    bool containsPokemon;
    public Pokeball(int index)
    {
        new Charmander(charCount: index, strength: "Fire", weakness: "Water");
        containsPokemon = true;
    }
}