using System;

namespace RockPaperScissors
{
    class Program
    {
        static void WriteLineInColor(ConsoleColor c, string s)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static string GetComputerChoice()
        {
            int choice = new Random().Next(1, 4);
            string output = String.Empty;

            switch (choice) {
                case 1:
                    output = "rock";
                    break;
                case 2:
                    output = "paper";
                    break;
                case 3:
                    output = "scissors";
                    break;
            }
            return output;
        }
        static void Main(string[] args)
        {
            WriteLineInColor(ConsoleColor.Green, "|-----------------------------|\n|   ROCK, PAPER, SCISSORS!    |\n|      by John Crowley        |\n|-----------------------------|\n");

            Console.WriteLine("Enter your name, frendo: ");

            string name = Console.ReadLine();

            Console.WriteLine($"Aight, {name}. Let's play...\n");

            while (true)
            {
                WriteLineInColor(ConsoleColor.Yellow, "Rock[r], paper,[p], or scissors[s]?");

                string playerChoice = Console.ReadLine();

                string computerChoice = GetComputerChoice();

                if (playerChoice == "r" && computerChoice == "rock"
                    || playerChoice == "p" && computerChoice == "paper"
                    || playerChoice == "s" && computerChoice == "scissors")
                {
                    Console.WriteLine($"\n{computerChoice.ToUpper()}! It's a draw...\n");
                } else if (playerChoice == "r" && computerChoice == "paper"
                    || playerChoice == "p" && computerChoice == "scissors"
                    || playerChoice == "s" && computerChoice == "rock")
                {
                    Console.WriteLine($"\n{computerChoice.ToUpper()}! You lose!\n");
                } else if (playerChoice == "r" && computerChoice == "scissors"
                    || playerChoice == "p" && computerChoice == "rock"
                    || playerChoice == "s" && computerChoice == "paper")
                {
                    Console.WriteLine($"\n{computerChoice.ToUpper()}! You win!\n");
                }
            }

        }
    }
}
