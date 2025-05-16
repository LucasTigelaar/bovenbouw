namespace Pokemon_Battle_Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Press any button to start the game");
        Console.ReadKey();
        Console.Clear();

        List<Pokeball> BeltTrainerOne = new List<Pokeball>();
        List<Pokeball> BeltTrainerTwo = new List<Pokeball>();

        int beltCapacity = 6;

        int Flag = 2;
        for (int i = 0; i < Flag; i++)
        {
            if (BeltTrainerOne.Count() > beltCapacity || BeltTrainerTwo.Count() > beltCapacity)
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

        Shuffle(BeltTrainerOne);
        Shuffle(BeltTrainerTwo);

        Trainer trainerOne = new Trainer(nickname: Naming(text: "Choose your first trainers name:"), belt: BeltTrainerOne); 
        Trainer trainerTwo = new Trainer(nickname: Naming(text: "Choose your second trainers name:"), belt: BeltTrainerTwo);

        Console.Clear();

        Arena arena = new Arena();
        arena.Arena_(TrainerOne: trainerOne, TrainerTwo: trainerTwo);
    }

    static string Naming(string text)
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

    static void Shuffle<T>(List<T> unShuffledList)
    {
        Random rnd = new Random();
        for (int index = unShuffledList.Count - 1; index > 0; --index)
        {
            int rndInt = rnd.Next(index + 1);
            (unShuffledList[index], unShuffledList[rndInt]) = (unShuffledList[rndInt], unShuffledList[index]);
        }
    }
}