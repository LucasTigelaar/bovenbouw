namespace Pokemon_Battle_Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to start the game");
        Console.ReadLine();

        List<Pokeball> BeltTrainerOne = new List<Pokeball>();
        List<Pokeball> BeltTrainerTwo = new List<Pokeball>();

        for (int i = 0; i < 6; i++)
        {
            if (BeltTrainerOne.Count() > 6)
            {
                throw new ArgumentException("A trainers belt can only contain 6 Pokeballs.");
            }

            Charmander charmander_1 = new Charmander(charCount: i);
            Pokeball pokeball_1 = new Pokeball(ballCount: i, containsPokemon: true, charmanderInPokeball: charmander_1);
            BeltTrainerOne.Add(pokeball_1);

            Charmander charmander_2 = new Charmander(charCount: i+6);
            Pokeball pokeball_2 = new Pokeball(ballCount: i+6, containsPokemon: true, charmanderInPokeball: charmander_2);
            BeltTrainerTwo.Add(pokeball_2);
        }

        Trainer trainerOne = new Trainer(nickname: Naming("Choose your first trainers name:"), belt: BeltTrainerOne);

        Trainer trainerTwo = new Trainer(nickname: Naming("Choose your second trainers name:"), belt: BeltTrainerTwo);
        //Console.WriteLine(trainerTwo.Belt[3].CharmanderInPokeball.Name);

        List<string> howManieth = new List<string>()
        {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth"
        };

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"\nPress Enter to start round {i+1}. Type 'quit' to quit.");
            string answer = Console.ReadLine().ToLower();

            if (answer == "quit")
            {
                break;
            }

            trainerOne.ThrowPokeball(count: howManieth[i], index: i);
            trainerTwo.ThrowPokeball(count: howManieth[i], index: i);

            trainerOne.Belt[i].CharmanderInPokeball.DoBattleCry();
            trainerTwo.Belt[i].CharmanderInPokeball.DoBattleCry();

            trainerOne.ReturnPokeball(count: howManieth[i], index: i);
            trainerTwo.ReturnPokeball(count: howManieth[i], index: i);
        }
    }

    public static string Naming(string text)
    {
        while (true)    
        {
            Console.WriteLine(text);
            string name = Console.ReadLine().Trim();
            bool nameIsValid = true;

            foreach (Char ch in name)
            {
                if (Char.IsLetter(ch) == false && Char.IsWhiteSpace(ch) == false)
                {
                    nameIsValid = false;
                }
            }

            if (name != "" && nameIsValid)
            {
                return Char.ToUpper(name[0]) + name.Substring(1).ToLower();
            }
            Console.WriteLine("Invalid input, try again.");
        }
    }
}