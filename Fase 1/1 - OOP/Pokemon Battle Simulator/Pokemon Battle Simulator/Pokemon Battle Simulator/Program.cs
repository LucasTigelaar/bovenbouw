using Pokemon_Battle_Simulator;

// naming method
static string Naming()
{
    Console.WriteLine("Choose your Charmanders name:");
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
static void Attack(string name)
{
    Console.WriteLine("Charmander uses Battle Cry!");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{name.ToUpper()}!!!!");
    }
}

// start
Console.WriteLine("Press Enter to start");
Console.ReadLine();
Charmander charmanderObject = new Charmander(); // make new Charmander object

charmanderObject.name = Naming(); // initial naming
Attack(charmanderObject.name); // initial attack

string answer = "";
while (answer != "2")
{
    while (true)
    {
        Console.WriteLine("Type '1' to rename your Charmander or type '2' to stop playing:");
        answer = Console.ReadLine().ToLower();
        if (answer == "1")
        {
            charmanderObject.name = Naming(); // optional rename
            break;
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
    Attack(charmanderObject.name); // following attack
}