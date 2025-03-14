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

    public void ThrowPokeball()
    {
        Console.WriteLine("Test");
    }
}