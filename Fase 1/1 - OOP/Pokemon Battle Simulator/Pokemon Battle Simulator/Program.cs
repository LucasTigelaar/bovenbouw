namespace Pokemon_Battle_Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        // start
        Console.WriteLine("Press Enter to choose Charmander");
        Console.ReadLine();

        Charmander charmanderObject = new Charmander(nickname: "", strength: "Fire", weakness: "Water"); // make new Charmander object
        
        charmanderObject.Name = Naming(); // initial naming
        Attack(charmanderObject); // initial attack

        string answer = "";
        while (true)
        {
            Console.WriteLine("Type '1' to rename your Charmander or type '2' to stop playing:");
            answer = Console.ReadLine().ToLower();
            if (answer == "1")
            {
                charmanderObject.Name = Naming(); // optional rename
                Attack(charmanderObject); // following attack
            }
            else if (answer == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

    // naming method
    private static string Naming()
    {
        Console.WriteLine("Choose their name:");
        string name = "";
        while (true)    
        {
            name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Invalid input, try again:");
            }
            else
            {
                return name;
            }
        }
    }

    // attack method
    private static void Attack(Charmander poke)
    {
        Console.WriteLine("Charmander uses Battle Cry!");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(poke.DoBattleCry());
        }
    }

    // create trainer
    //public Trainer CreateTrainer()
    //{
    //    Console.WriteLine(GetType().Name);
    //}
}

// alt enter is your friend