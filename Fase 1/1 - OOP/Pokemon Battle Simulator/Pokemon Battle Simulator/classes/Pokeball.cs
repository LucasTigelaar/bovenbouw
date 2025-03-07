namespace Pokemon_Battle_Simulator;

public class Pokeball
{
    public Pokeball()
    {
        Console.WriteLine(GetType().Name);
        //return null;
    }

    public void Throw()
    {
        Console.WriteLine(GetType().Name);
    }

    public void Return()
    {
        Console.WriteLine(GetType().Name);
    }
}