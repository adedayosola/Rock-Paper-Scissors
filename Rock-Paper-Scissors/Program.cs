using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("Choose between Rock, Paper and Scissors:  ");
            InputPlayer = Console.ReadLine();
            InputPlayer = InputPlayer.ToUpper();

            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (InputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (InputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (InputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("COMPUTER WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                    if (InputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (InputPlayer == "ROCK")
                    {
                        Console.WriteLine("COMPUTER WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (InputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if (InputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (InputPlayer == "PAPER")
                    {
                        Console.WriteLine("COMPUTER WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (InputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    break;
                default:
                    Console.Write("Invaid Entry");
                    break;

            }
        }
    }
}
