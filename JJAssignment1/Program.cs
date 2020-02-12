/* 
 * Program.cs
 * Assignment1
 * 
 *  Revision History
 *      Jeonghwan Ju, 2020.02.11: Created
 */
using System;

namespace JJAssignment1
{
    /// <summary>
    /// Main Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Input Radius from User
        /// </summary>
        /// <returns>Radius integer value</returns>
        public static int InputRadius()
        {
            bool checkInput = false;

            // Input radius of circle
            int radius = 0;
            string radiusInput = "";

            while (!checkInput)
            {
                Console.WriteLine();
                Console.Write("Please enter the radius of the circle [Number]: ");

                // The radius must be an integer greater than 0
                radiusInput = Console.ReadLine();

                if (!int.TryParse(radiusInput, out radius))
                {
                    checkInput = false;

                    Console.WriteLine();
                    Console.WriteLine("You must enter integer number.");
                    Console.WriteLine("Your input: " + radiusInput);
                    Console.WriteLine();
                }
                else if (int.Parse(radiusInput) <= 0)
                {
                    checkInput = false;

                    Console.WriteLine();
                    Console.WriteLine("You must enter integer greater than 0.");
                    Console.WriteLine("Your input: " + radiusInput);
                    Console.WriteLine();
                }
                else
                {
                    checkInput = true;

                    Console.WriteLine();
                    Console.WriteLine("Radius has been successfully registered.");
                    Console.WriteLine("Your input: " + radiusInput);
                    Console.WriteLine();

                    radius = int.Parse(radiusInput);
                }
            }

            return radius;
        }

        /// <summary>
        /// Display Menu
        /// </summary>
        public static void DisplayMenu()
        {
            // Display menu lists
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("**** Menu ****");
            Console.WriteLine("========================================");
            Console.WriteLine("1.Get Circle Radius");
            Console.WriteLine("2.Change Circle Radius");
            Console.WriteLine("3.Get Circle Circumference");
            Console.WriteLine("4.Get Circle Area");
            Console.WriteLine("5.Exit");
            Console.WriteLine();
            Console.Write("Enter the menu [1,2,3,4,5]: ");
        }

        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Display title
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("PROG2070 Quality Assurance Assignment 01");
            Console.WriteLine("========================================");
            Console.WriteLine("Name: Jeonghwan Ju");
            Console.WriteLine("========================================");
            Console.WriteLine();

            // Class variables
            Circle circle;

            bool exitProgram = false;

            // Input radius of circle
            int radius = InputRadius();

            // Initialize Circle Class Variable
            circle = new Circle(radius);

            string menuInput = "";

            while (!exitProgram)
            {
                // Display main menu lists
                DisplayMenu();

                menuInput = Console.ReadLine();
                    
                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("1. Get Circle Radius: " + circle.GetRadius().ToString());
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return menu.");
                        Console.ReadLine();
                        break;

                    case "2":
                        // Input radius of circle
                        radius = InputRadius();

                        // Set Radius
                        circle.SetRadius(radius);
                        Console.WriteLine("2. Change Circle Radius: " + circle.GetRadius().ToString());
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return menu.");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("3. Get Circle Circumference: " + circle.GetCircumference().ToString());
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return menu.");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("4. Get Circle Area: " + circle.GetArea().ToString());
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return menu.");
                        Console.ReadLine();
                        break;

                    case "5":
                        exitProgram = true;

                        Console.WriteLine();
                        Console.WriteLine("Program will be terminated.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter '1','2','3','4',or'5'.");
                        Console.WriteLine("Your input: " + menuInput);
                        Console.WriteLine();
                        break;
                }
            }

            return;
        }
    }
}
