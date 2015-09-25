using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePSR
{
    class Program
    {
        static void Main(string[] args)
        {
            bool QUIT = false;
            //do
            //{
           
                
            
            Console.WriteLine("Please select one or two player:");//\nEnter Quit to quit:");
                string userValue = Console.ReadLine();
                int a = int.Parse(userValue);

                for (int i = 0; i < 5; i++)
            {
               //// if (userValue == "QUIT")
               // {
               //     break;
               // }
            switch (a)
            {
                case 2:
                {
                    PaperScissorRock gameOne = new PaperScissorRock();
                    gameOne.twoPlayer();
                    Console.Clear();
                    break;
                }
                case 1:
                {
                    PaperScissorRock game = new PaperScissorRock();
                    game.computerPlay();
                    Console.Clear();
                    break;
                }



            }
        }


          //  } while (QUIT == false);
        
        }
    }
}
