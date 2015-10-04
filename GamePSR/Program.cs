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
            try
            {
            Console.BackgroundColor = ConsoleColor.Blue; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please select one or two player:");
                string userValue = Console.ReadLine();
                int a = Int32.Parse(userValue);

                for (int i = 0; i < 5; i++)
                {
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
            }
            catch (Exception)
            {

                throw new Exception("Error-");

            }
        }
    }
}
