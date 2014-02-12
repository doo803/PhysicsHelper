using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicsHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Select topic
            ChooseTopic();
            
            // Stop program closing immediately
            Console.ReadLine();
        }

        static void WriteTitle()
        {
            // Text region title
            #region
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("                   Physics Helper - 'Doo803 | The De-Minisher'");
            Console.WriteLine("-------------------------------------------------------------------------------");
            #endregion
        }

        public static void ChooseTopic()
        {
            // Write title
            WriteTitle();

            Console.WriteLine("Options to choose from: ");

            // Print options
            #region
            Console.Write("1. Mechanics\n\n");
            #endregion

            // Make choice
            #region

            Console.Write("Please input the number of desired option, then press enter: ");
            int choice;
            string input = Console.ReadLine();
            bool result = Int32.TryParse(input, out choice);

            // Give error message and repeat choice if input was not a string
            if (!result)
            #region
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("                             Oops, that's an error...");
                Console.WriteLine("-------------------------------------------------------------------------------");
                
                Console.WriteLine("Input could not be read as a valid integer.");
                Console.Write("Press enter to try again..."); Console.ReadLine();
                Console.Clear();
                ChooseTopic();
            }
            #endregion

            else
            #region
            {
                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Mechanics.StartMechanics();                            
                            break;
                        }

                    // If choice does not match a result
                    default:
                        #region
                        {
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine("                             Oops, that's an error...");
                            Console.WriteLine("-------------------------------------------------------------------------------");

                            Console.WriteLine("Input was read as a valid integer, but did not match a choice.");
                            Console.Write("Press enter to try again..."); Console.ReadLine();
                            Console.Clear();
                            ChooseTopic();
                            break;
                        }
                        #endregion
                }
            }
            #endregion

            #endregion

        }
    }
}
