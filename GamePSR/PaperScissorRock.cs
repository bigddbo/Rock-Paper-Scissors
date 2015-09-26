using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GamePSR
{
    class PaperScissorRock
    {

         static void PlaySound(string filePath)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @filePath;
            player.controls.play();
        }


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
                string choice = Console.ReadLine(); Console.Clear();

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
                    else if (choice == "D")
                    {
                        return "D";
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
             return ("Try again");
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
            else if (choice == "D")
            {
                return "Dynamite";
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
            else if ((humanInput == "D" && computerInput == "R") || (humanInput == "D" && computerInput == "S") || (humanInput == "D" && computerInput == "P")) 
            {
                Console.WriteLine("YOU HAVE FOUND A CHEAT DYNAMITE WINS");
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
            else if (playerOne == "D")
            {
                Console.WriteLine("Player one has dynamite. PLAYER ONE YOU WIN");
            }
            else if (playerTwo == "D")
            {
                Console.WriteLine("Player two has dynamite. PLAYER TWO YOU WIN");
            }
            else
            {
                Console.WriteLine("The player two wins");
            }
        }
    }
}
