namespace Pokemon_Battle_Simulator;

public class Trainer
{
    public string Name = "";
    public List<Pokeball> Belt;

    public Trainer(string nickname)
    {
        Name = nickname;
        Belt = new List<Pokeball>();
        for (int i = 1; i <= 6; i++)
        {
            Belt.Add(new Pokeball(index: i));
        }
    }
}