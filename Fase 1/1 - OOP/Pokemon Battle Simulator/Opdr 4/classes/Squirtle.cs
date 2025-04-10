namespace Pokemon_Battle_Simulator;

public class Squirtle : Pokemon
{
    public string NickName;
    public Squirtle(string nickName) : base(strength: "water", weakness: "leaf", name: nickName)
    {
        NickName = nickName;
    }
    public override void DoBattleCry()
    {
        Console.WriteLine($"{NickName} uses Battle Cry!\n{NickName.ToUpper()}!!!!");
    }
}