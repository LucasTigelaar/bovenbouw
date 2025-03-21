namespace Pokemon_Battle_Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to start the game");
        Console.ReadLine();

        List<Pokeball> BeltTrainerOne = new List<Pokeball>();
        List<Pokeball> BeltTrainerTwo = new List<Pokeball>();

        int Flag = 2;
        for (int i = 0; i < Flag; i++)
        {
            if (BeltTrainerOne.Count() > 6 || BeltTrainerTwo.Count() > 6)
            {
                throw new ArgumentException("A trainers belt can only contain 6 Pokeballs.");
            }

            BeltTrainerOne.Add(new Pokeball(ballCount: i, containsPokemon: true, pokemonInPokeball: new Charmander($"Charmander_{i}")));
            BeltTrainerOne.Add(new Pokeball(ballCount: i, containsPokemon: true, pokemonInPokeball: new Bulbasaur($"Bulbasaur_{i}")));
            BeltTrainerOne.Add(new Pokeball(ballCount: i, containsPokemon: true, pokemonInPokeball: new Squirtle($"Squirtle_{i}")));

            BeltTrainerTwo.Add(new Pokeball(ballCount: i + Flag, containsPokemon: true, pokemonInPokeball: new Charmander($"Charmander_{i + Flag}")));
            BeltTrainerTwo.Add(new Pokeball(ballCount: i + Flag, containsPokemon: true, pokemonInPokeball: new Bulbasaur($"Bulbasaur_{i + Flag}")));
            BeltTrainerTwo.Add(new Pokeball(ballCount: i + Flag, containsPokemon: true, pokemonInPokeball: new Squirtle($"Squirtle_{i + Flag}")));
        }

        Trainer trainerOne = new Trainer(nickname: Naming("Choose your first trainers name:"), belt: BeltTrainerOne);
        Trainer trainerTwo = new Trainer(nickname: Naming("Choose your second trainers name:"), belt: BeltTrainerTwo);

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

            trainerOne.Belt[i].PokemonInPokeball.DoBattleCry();
            trainerTwo.Belt[i].PokemonInPokeball.DoBattleCry();

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