namespace Pokemon_Battle_Simulator;

public class Bulbasaur : Pokemon
{
    public string NickName;
    public Bulbasaur(string nickName) : base(strength: "grass", weakness: "fire", name: nickName)
    {
        NickName = nickName;
    }
    public override void DoBattleCry()
    {
        Console.WriteLine($"{NickName} uses Battle Cry!\n{NickName.ToUpper()}!!!!");
    }
}