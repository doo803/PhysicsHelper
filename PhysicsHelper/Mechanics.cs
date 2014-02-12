using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicsHelper
{
    public class Mechanics
    {
        public static void StartMechanics()
        {
            ChooseModule();
        }

        static void WriteTitle()
        {
            // Text region title
            #region
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("                           Topic Selected - Mechanics");
            Console.WriteLine("-------------------------------------------------------------------------------");
            #endregion
        }

        public static void ChooseModule()
        {
            // Clear console
            Console.Clear();

            // Write title
            WriteTitle();

            Console.WriteLine("Options to choose from: ");

            // Print options
            #region
            Console.WriteLine("[#]  [Module]                    [Required data]");   
            Console.WriteLine("1    Distance traveled           Time, Velocity");
            Console.WriteLine("2    Average Velocity            Time, Distance");
            Console.WriteLine("3    Accleration                 Time, Velocity");
            Console.WriteLine("\n0    ** Return to topic selection **");
            #endregion

            // Make choice
            #region

            Console.Write("\nPlease input the number of desired option, then press enter: ");
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
                ChooseModule();
            }
            #endregion

            else
            #region
            {
                switch (choice)
                {
                    case 0:
                        {
                            Console.Clear();
                            Program.ChooseTopic();
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            DistanceTraveled();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            AverageVelocity();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Acceleration();
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
                            ChooseModule();
                            break;
                        }
                        #endregion
                }
            }
            #endregion

            #endregion

        }

        static void DistanceTraveled()
        {
            #region
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("                              Distance Traveled");
            Console.WriteLine("-------------------------------------------------------------------------------\n");

            Console.WriteLine("Please input values for the following (Use 0 if value is unknown)");
            Console.WriteLine("** NOTE: ONE value must be unknown, no more, no less ** \n");
            Console.Write("Distance Traveled (Metres): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Time Taken (Seconds): ");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.Write("Average Velocity (Metres/Second): ");
            double velocity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("                                   Results");
            Console.WriteLine("-------------------------------------------------------------------------------");
            if(distance != 0)
            Console.WriteLine("\nDistance Traveled = {0} metres", distance);

            else
            Console.WriteLine("\nDistance Traveled = {0} metres", (time * velocity));    

            if(time != 0)
            Console.WriteLine("\nTime Taken = {0} seconds", time);

            else
            Console.WriteLine("\nTime Taken = {0} seconds", (distance / velocity));

            if(velocity != 0)
            Console.WriteLine("\nVelocity = {0} metres / second", velocity);

            else
            Console.WriteLine("\nVelocity = {0} metres / second", (distance / time));

            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("Press 'R' to use this module again, 'ESC' to return to Module Selection");

            ConsoleKeyInfo proceedKey = Console.ReadKey();
            if (proceedKey.Key == ConsoleKey.R)
            {
                DistanceTraveled();
            }

            else if (proceedKey.Key == ConsoleKey.Escape)
            {
                ChooseModule();
            }
            #endregion
        }

        static void AverageVelocity()
        {
            #region
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("                              Average Velocity");
            Console.WriteLine("                      ** Assuming constant acceleration **");
            Console.WriteLine("-------------------------------------------------------------------------------\n");

            
        }

        static void Acceleration()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("                                 Acceleration");
            Console.WriteLine("-------------------------------------------------------------------------------\n");

            Console.WriteLine("Please input values for the following (Use 0 if value is unknown)");
            Console.WriteLine("** NOTE: ONE value must be unknown, no more, no less ** \n");

            Console.Write("Initial Velocity (Metres/Second): ");
            double initVelocity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Velocity (Metres/Second): ");
            double finalVelocity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Time Taken (Seconds): ");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.Write("Acceleration (Metres/Seconds^2): ");
            double acceleration = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("                                   Results");
            Console.WriteLine("-------------------------------------------------------------------------------");

            if (initVelocity != 0)
                Console.WriteLine("\nInitial velocity = {0} metres / second", initVelocity);

            else
                Console.WriteLine("\nInitial velocity = {0} metres / second", (finalVelocity - (acceleration * time)));

            if (finalVelocity != 0)
                Console.WriteLine("\nFinal velocity = {0} metres / second", finalVelocity);

            else
                Console.WriteLine("\nFinal velocity = {0} metres / second", (initVelocity + (acceleration * time)));

            if (time != 0)
                Console.WriteLine("\nTime Taken = {0} seconds", time);

            else
                Console.WriteLine("\nTime Taken = {0} seconds", ((finalVelocity - initVelocity) / acceleration));

            if (acceleration != 0)
                Console.WriteLine("\nAcceleration = {0} metres / seconds^2", acceleration);

            else
                Console.WriteLine("\nAcceleration = {0} metres / seconds^2", ((finalVelocity - initVelocity) / time));

            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("Press 'R' to use this module again, 'ESC' to return to Module Selection");

            ConsoleKeyInfo proceedKey = Console.ReadKey();
            if (proceedKey.Key == ConsoleKey.R)
            {
                Acceleration();
            }

            else if (proceedKey.Key == ConsoleKey.Escape)
            {
                ChooseModule();
            }
            #endregion
        }
    }
}
