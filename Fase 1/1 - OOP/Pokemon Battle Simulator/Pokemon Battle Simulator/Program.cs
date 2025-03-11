namespace Pokemon_Battle_Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        //1.The player starts the game.
        Console.WriteLine("Press Enter to start the game");
        Console.ReadLine();

        //2.The player gives a name to the first trainer.
        Trainer trainerOne = new Trainer(nickname: Naming("Choose your first trainers name:"));

        //3.The player gives a name to the second trainer.
        Trainer trainerTwo = new Trainer(nickname: Naming("Choose your second trainers name:"));

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
                if (Char.IsLetter(ch) && Char.IsWhiteSpace(ch))
                {
                    continue;
                }
                nameIsValid = false;
                break;
            }

            if (name != "" && nameIsValid)
            {
                return Char.ToUpper(name[0]) + name.Substring(1).ToLower();
            }
            else
            {
                Console.WriteLine("Invalid input, try again:");
            }
        }
    }
}