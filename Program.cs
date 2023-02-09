using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors_shorter
{
    internal class Program
    {
        static int playerAWins = 0;
        static int playerBWins = 0;
        public class NewMethod
        {
            public void Score()
            {
                {
                    Console.WriteLine("PlayerA score is: " + playerAWins + "p");
                    Console.WriteLine("PlayerB score is: " + playerBWins + "p");
                }
            }
            public void StartShorterGame()
            {
                playerAWins = 0;
                playerBWins = 0;

                Func<string, string, string> game = (playerA, playerB) =>
                {
                    if (playerA == playerB)
                    {
                        return "DRAW";
                    }
                    else if (playerA == "rock" && playerB == "paper")
                    {
                        return "PlayerB wins this round";
                    }
                    else if (playerA == "rock" && playerB == "scissors")
                    {
                        return "PlayerA wins this round";
                    }
                    else if (playerA == "paper" && playerB == "rock")
                    {
                        return "PlayerA wins this round";
                    }
                    else if (playerA == "paper" && playerB == "scissors")
                    {
                        return "PlayerB wins this round";
                    }
                    else if (playerA == "scissors" && playerB == "rock")
                    {
                        return "PlayerB wins this round";
                    }
                    else if (playerA == "scissors" && playerB == "paper")
                    {
                        return "PlayerA wins this round";
                    }
                    else
                    {
                        return "Wrong input";
                    }
                };

                int roundsPlayed = 0;
                Console.WriteLine("Enter the number of rounds: ");
                var RockPaperScissors = new List<string>() { "rock", "paper", "scissors" };
                Random rnd = new Random();
                int selectedRounds = int.Parse(Console.ReadLine());
                var roundedNums = (int)((selectedRounds / 2) + 0.5);
                while (selectedRounds % 2 == 0)
                {
                    Console.WriteLine("Wrong number, please enter an odd number: ");
                    selectedRounds = int.Parse(Console.ReadLine());
                }
                while (roundsPlayed < selectedRounds)
                {
                    var playerAChoice = RockPaperScissors[rnd.Next(RockPaperScissors.Count)];
                    Console.Write("*****Player A chooses: " + playerAChoice + "\n");
                    var playerBChoice = RockPaperScissors[rnd.Next(RockPaperScissors.Count)];
                    Console.Write("*****Player B chooses: " + playerBChoice + "\n");

                    string result = game(playerAChoice, playerBChoice);
                    Console.WriteLine(result);

                    if (result.StartsWith("PlayerA"))
                    {
                        playerAWins++;
                        if (playerAWins > roundedNums)
                        {
                            Console.WriteLine("PlayerA won the game!");
                            break;
                        }
                    }
                    else if (result.StartsWith("PlayerB"))
                    {
                        playerBWins++;
                        if (playerBWins > roundedNums)
                        {
                            Console.WriteLine("PlayerB won the game!");
                            break;
                        }
                    }
                    roundsPlayed++;
                }
                if (playerAWins > playerBWins)
                {
                    Console.WriteLine("PlayerA won the game!");
                }
                if (playerBWins > playerAWins)
                {
                    Console.WriteLine("Player B won the game!");
                }
                if (playerAWins == playerBWins)
                {
                    Console.WriteLine("It's a tie! Play again.");
                }
            }
            static void Main(string[] args)
            {
                var refObj = new NewMethod();
                while (true)
                {
                    Console.WriteLine("Enter 'start' to start a game or 'score to check the score");
                    string command = Console.ReadLine().ToLower();
                    if (command == "start")
                    {
                        refObj.StartShorterGame();
                    }
                    else if (command == "score")
                    {
                        refObj.Score();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command");
                    }
                }
            }
        }
    }
}