namespace Pokemon_Battle_Simulator;

public class Arena
{
    Trainer trainerOne;
    Trainer trainerTwo;

    static int roundsFought;
    static int battlesFought;

    public void Arena_(Trainer TrainerOne, Trainer TrainerTwo)
    {
        trainerTwo = TrainerTwo;
        trainerOne = TrainerOne;
        List<string> howManieth = new List<string>()
            {
                "first",
                "second",
                "third",
                "fourth",
                "fifth",
                "sixth"
            };

        while (true)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"\nRound {i + 1}.");

                trainerOne.ThrowPokeball(count: howManieth[i], index: i);
                trainerTwo.ThrowPokeball(count: howManieth[i], index: i);

                trainerOne.Belt[i].PokemonInPokeball.DoBattleCry();
                trainerTwo.Belt[i].PokemonInPokeball.DoBattleCry();

                trainerOne.ReturnPokeball(count: howManieth[i], index: i);
                trainerTwo.ReturnPokeball(count: howManieth[i], index: i);

                roundsFought++;

                Thread.Sleep(2000);
            }
            battlesFought++;

            Console.WriteLine($"\nPress Enter to play again. Type 'quit' to quit.");
            string answer = Console.ReadLine().ToLower();
            Console.Clear();

            if (answer == "quit")
            {
                Console.WriteLine($"Rounds fought: {roundsFought}\nBattles fought: {battlesFought}");
                break;
            }
        }
    }
}