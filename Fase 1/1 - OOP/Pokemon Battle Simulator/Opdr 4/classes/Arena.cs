namespace Pokemon_Battle_Simulator;

public class Arena
{
    Trainer trainerOne;
    Trainer trainerTwo;

    static int roundsFought;
    static int battlesFought;

    static int trainerOneScore;
    static int trainerTwoScore;
    static int trainerOneScoreTotal;
    static int trainerTwoScoreTotal;

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

                Pokemon pokemonOne = trainerOne.ThrowPokeball(count: howManieth[i], index: i);
                Pokemon pokemonTwo = trainerTwo.ThrowPokeball(count: howManieth[i], index: i);

                pokemonOne.DoBattleCry();
                pokemonTwo.DoBattleCry();

                string winnerOfRound = CheckWinner(pokemonOne, pokemonTwo);

                if (winnerOfRound == pokemonOne.Name)
                {
                    Console.WriteLine($"Winner: {winnerOfRound}");
                    trainerOneScore++;
                }
                else if (winnerOfRound == pokemonTwo.Name)
                {
                    Console.WriteLine($"Winner: {winnerOfRound}");
                    trainerTwoScore++;
                }
                else
                {
                    Console.WriteLine("Draw!");
                }


                trainerOne.ReturnPokeball(count: howManieth[i], index: i);
                trainerTwo.ReturnPokeball(count: howManieth[i], index: i);

                roundsFought++;

                Thread.Sleep(3000);
            }
            battlesFought++;

            if (trainerOneScore > trainerTwoScore)
            {
                Console.WriteLine($"The winner is {trainerOne.Name}!");
                trainerOneScoreTotal++;
            }
            else if (trainerOneScore < trainerTwoScore)
            {
                Console.WriteLine($"The winner is {trainerTwo.Name}!");
                trainerTwoScoreTotal++;
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.WriteLine($"\nPress Enter to play again. Type 'quit' to quit.");
            string answer = Console.ReadLine().ToLower();
            Console.Clear();

            if (answer == "quit")
            {
                Console.WriteLine($"Rounds fought: {roundsFought}");
                Console.Clear();
                break;
            }
        }

        Console.WriteLine($"Battles fought: {battlesFought}");
        Console.WriteLine($"\nTrainer {trainerOne.Name} score: {trainerOneScoreTotal}");
        Console.WriteLine($"Trainer {trainerTwo.Name} score: {trainerTwoScoreTotal}\n");

        if (trainerOneScoreTotal > trainerTwoScoreTotal)
        {
            Console.WriteLine($"The winner is {trainerOne.Name}!");
        }
        else if (trainerOneScoreTotal < trainerTwoScoreTotal)
        {
            Console.WriteLine($"The winner is {trainerTwo.Name}!");
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
    }

    static string CheckWinner(Pokemon _pokemonOne, Pokemon _pokemonTwo)
    {
        if (_pokemonOne.Strength == _pokemonTwo.Weakness)
        {
            return _pokemonOne.Name;
        }
        else if (_pokemonOne.Weakness == _pokemonTwo.Strength)
        {
            return _pokemonTwo.Name;
        }
        return null;
    }
}