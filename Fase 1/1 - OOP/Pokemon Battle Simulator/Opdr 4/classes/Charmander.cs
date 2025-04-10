namespace Pokemon_Battle_Simulator;

public class Charmander : Pokemon
{
    public string NickName;
    public Charmander(string nickName) : base(strength: "fire", weakness: "water", name: nickName)
    {
        NickName = nickName;
    }
    public override void DoBattleCry()
    {
        Console.WriteLine($"{NickName} uses Battle Cry!\n{NickName.ToUpper()}!!!!");
    }
}