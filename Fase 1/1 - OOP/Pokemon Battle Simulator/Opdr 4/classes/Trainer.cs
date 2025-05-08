namespace Pokemon_Battle_Simulator;

public class Trainer
{
    public string Name = "";
    public List<Pokeball> Belt;

    public Trainer(string nickname, List<Pokeball> belt)
    {
        Name = nickname;
        Belt = belt;
    }

    public Pokemon ThrowPokeball(string count, int index)
    {
        Console.WriteLine($"Trainer {Name} threw their {count} pokeball.");
        Pokemon pokemon = Belt[index].OpenPokeball();
        return pokemon;
    }

    public void ReturnPokeball(string count, int index)
    {
        Console.WriteLine($"Trainer {Name} returned their {count} pokeball");
        Belt[index].ClosePokeball();
    }
}