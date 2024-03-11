using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //method to choose Rock, Paper or Scissors
            static string choose()
            {
                Random rnd = new Random();  
                int choice;
                string played;

                choice = rnd.Next(0, 2);
                if (choice == 0)
                {
                    played = "rock";
                } else if (choice == 1)
                {
                    played = "scissors";
                } else {
                    played = "paper";
                }
                return played;
            }
            //method to play
            static void play()
            {
                string playerChoice;
                string computerChoice;
                string replay = "yes";

                Console.WriteLine("Lets play Rock, Paper, Scissors! \nChoose your play: ");

                //log player choice
                while (replay == "yes") { 
                playerChoice = Console.ReadLine();
                computerChoice = choose();

                //calculate computer choice
                //put choices up against each other
                if ((playerChoice == "rock" &&  computerChoice == "scissors") || (playerChoice == "paper" && computerChoice == "rock") || (playerChoice == "scissors" && computerChoice == "paper"))
                {
                    Console.WriteLine(computerChoice);
                    Console.WriteLine("Player 1 Wins \n Play again?");
                    replay = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(computerChoice);
                    Console.WriteLine("Player 2 wins \n Play again?");
                    replay = Console.ReadLine();

                }
                }
                
            }

            play();
        }
    }
}