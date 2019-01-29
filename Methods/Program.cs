using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");

            try
            {
                // Read the user input as a string.
                string input = Console.ReadLine();

                /* As long as the user does not enter an empty value, the application executes the HelloName method
                 * based on the user's input.
                 */
                if (input != "")
                {
                    Console.WriteLine("");
                    HelloName(input);

                    // Provide closing instructions.
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                // If the user enters an empty value, the application provides instructions to try again.
                else
                {
                    Console.WriteLine("Please run the program again and enter a valid name.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }
            // Catch block delivers instructions 
            catch
            {
                Console.WriteLine("Please run the program again and enter a valid name.");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }

        // HelloName method reads the input and outputs a greeting to the user.
        private static void HelloName (string input)
        {
            Console.WriteLine("Hello " + input + "!");
        }
    }
}
