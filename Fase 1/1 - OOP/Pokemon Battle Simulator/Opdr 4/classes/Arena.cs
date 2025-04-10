namespace Pokemon_Battle_Simulator;

public class Arena
{
    public void Arena_(Trainer TrainerOne, Trainer TrainerTwo)
    {
        Trainer trainerOne = TrainerOne;
        Trainer trainerTwo = TrainerTwo;
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
            Console.WriteLine($"\nPress Enter to start round {i + 1}. Type 'quit' to quit.");
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
}