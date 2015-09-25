using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GamePSR
{
    class PaperScissorRock
    {

        Random random = new Random();

        public void computerPlay()
        {
            string userInput = correctInput();
            string comInput = computerChoice();

            Console.WriteLine("The human choice: {0}", letterToWord(userInput));
            Console.WriteLine("The computer choice: {0}",letterToWord(comInput));


            Winner(userInput, comInput);
            Console.ReadLine();

        }

        public void twoPlayer()
        {
            string userInput = correctInput();
            string secondInput = correctInput();

            Console.WriteLine("The first player: {0}", letterToWord(userInput));
            Console.WriteLine("The second player: {0}", letterToWord(secondInput));
            
            Winnertwoplayer(userInput,secondInput);
            Console.ReadLine();
        }

        //Player makes choice
        private string correctInput()
        {
            while (true)
            {
                Console.WriteLine("Please choice R for Rock, P for paper, or S for scissors: ");
                string choice = Console.ReadLine();

                while (true)
                {
                    if (choice == "R" || choice == "r")
                    {
                        return "R";
                    }
                    else if (choice == "P" || choice == "p")
                    {
                        return "P";
                    }
                    else if (choice == "S" || choice == "s")
                    {
                        return "S";
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }


        //Computer makes choice randomly
        private string computerChoice()
        {
            int number = random.Next(1, 4);
            if (number == 1)
            {
                return "R";
            }
            else if (number == 2)
            {
                return "P";
            }
            else if (number == 3)
            {
                return "S";
            }
            else
            {
                return "Please try again.";
            }
        }

        private string letterToWord(string choice)
        {
            if (choice == "P")
            {
                return "Paper";
            }
            else if (choice == "R")
            {
                return "Rock";
            }
            else if (choice == "S")
            {
                return "Scissors";
            }
            else
            {
                return "Please try again";
            }
        }
    // setting win vs loser between computer and human
        private void Winner(string humanInput, string computerInput)
        {
            if ((humanInput == "P" && computerInput == "R") || (humanInput == "R" && computerInput == "S") || (humanInput == "S" && computerInput == "P"))

            {
                Console.WriteLine("The human wins");
            }
            else if (humanInput == computerInput)
            {
                Console.WriteLine("Game is tie");
            }
            else
            {
                Console.WriteLine("The computer wins");
            }
        }
        private void Winnertwoplayer(string playerOne, string playerTwo)
        {
            if ((playerOne == "P" && playerTwo == "R") || (playerOne == "R" && playerTwo == "S") || (playerOne == "S" && playerTwo == "P"))

            {
                Console.WriteLine("The player one wins");
            }
            else if (playerOne == playerTwo)
            {
                Console.WriteLine("Game is tie");
            }
            else
            {
                Console.WriteLine("The player two wins");
            }
        }

    }
}
