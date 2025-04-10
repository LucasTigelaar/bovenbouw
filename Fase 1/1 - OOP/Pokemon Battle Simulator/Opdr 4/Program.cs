using System.Security.Cryptography.X509Certificates;

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

        //------------
        //1                 rnd.Next(count);
        //Bulbasaur_0       BeltTrainerOne[ran].PokemonInPokeball.Name
        //------------
        //0
        //Charmander_0
        //------------
        //4
        //Bulbasaur_1
        //------------
        //3
        //Charmander_1
        //------------
        //2
        //Squirtle_0
        //------------
        //5
        //Squirtle_1
        //------------

        Shuffle(BeltTrainerOne);
        Shuffle(BeltTrainerTwo);

        Trainer trainerOne = new Trainer(nickname: Naming(text: "Choose your first trainers name:"), belt: BeltTrainerOne);
        Trainer trainerTwo = new Trainer(nickname: Naming(text: "Choose your second trainers name:"), belt: BeltTrainerTwo);

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

    static void Shuffle<T>(List<T> list)
    {
        Random rnd = new Random();
        int count = list.Count();
        int last = count - 1;
        List<T> tmp;

        for (int i = count; i < 1; i++)
        {
            int num = rnd.Next(i + 1);
            tmp 
        }

    }
}