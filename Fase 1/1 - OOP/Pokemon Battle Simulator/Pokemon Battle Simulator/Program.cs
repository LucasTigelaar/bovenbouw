namespace Pokemon_Battle_Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        //1.The player starts the game.
        Console.WriteLine("Press Enter to start the game");
        Console.ReadLine();

        List<Pokeball> BeltTrainerOne = new List<Pokeball>();
        List<Pokeball> BeltTrainerTwo = new List<Pokeball>();

        for (int i = 0; i < 6; i++)
        {
            Charmander charmander_1 = new Charmander(charCount: i);
            Pokeball pokeball_1 = new Pokeball(ballCount: i, containsPokemon: true, charmanderInPokeball: charmander_1);
            BeltTrainerOne.Add(pokeball_1);

            Charmander charmander_2 = new Charmander(charCount: i+6);
            Pokeball pokeball_2 = new Pokeball(ballCount: i+6, containsPokemon: true, charmanderInPokeball: charmander_2);
            BeltTrainerTwo.Add(pokeball_2);
        }

        //2.The player gives a name to the first trainer.
        Trainer trainerOne = new Trainer(nickname: Naming("Choose your first trainers name:"), belt: BeltTrainerOne);

        //3.The player gives a name to the second trainer.
        Trainer trainerTwo = new Trainer(nickname: Naming("Choose your second trainers name:"), belt: BeltTrainerTwo);
        Console.WriteLine(trainerTwo.Belt[3].CharmanderInPokeball.Name);

        // koppel aan elke trainer zes unieke pokeballs door middel van lists


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
            Console.Write($"Press Enter to start round {i+1}");
            Console.ReadLine();

            //4.The first trainer throws the first/next pokeball on its belt.
            Console.Write($"Trainer {trainerOne.Name} throws their {howManieth[i]} pokeball!\n");

            //5.The pokeball released the charmander and charmander does its battle cry.
            Console.WriteLine(trainerOne.Name);
            trainerOne.ThrowPokeball();

            //6.The second trainer throws the first/next pokeball on its belt.
            Console.Write($"Trainer {trainerTwo.Name} throws their {howManieth[i]} pokeball!\n");

            //7.The pokeball released the charmander and charmander does its battle cry.

            //8.The first trainer returns the charmander back to its pokeball.

            //9.The second trainer returns the charmander back to its pokeball.

        }
    }
    //10.Repeat 4 to 9 until all pokeballs have been used by both trainers.
    //The player can quit or restart the game.

    public static string Naming(string text)
    {
        string name;
        bool nameIsValid = true;

        while (true)    
        {
            Console.WriteLine(text);
            name = Console.ReadLine().Trim();

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