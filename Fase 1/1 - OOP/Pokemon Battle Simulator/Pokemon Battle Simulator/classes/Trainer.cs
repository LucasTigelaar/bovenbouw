namespace Pokemon_Battle_Simulator;

public class Trainer
{
    public Trainer()
    {
        Console.WriteLine(GetType().Name);
        //return null;
    }

    public void ThrowPokeball()
    {
        Console.WriteLine(GetType().Name);
    }

    public void ReturnPokemon()
    {
        Console.WriteLine(GetType().Name);
    }
}