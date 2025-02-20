namespace Pokemon_Battle_Simulator
{
    public class Charmander
    {
        public string Name = "";
        public string Strength = "Fire";
        public string Weakness = "Water";

        public Charmander()
        {
            Console.WriteLine($"Player uses {GetType().Name}!\nStrength: {Strength}\nWeakness: {Weakness}");
        }

        public string DoBattleCry()
        {
            return $"{Name.ToUpper()}!!!!";
        }
    }
}