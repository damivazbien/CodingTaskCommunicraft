using System;
using CodingTaskLibrary;

namespace CodingTask
{
    class Program {
        static void Main(string[] args) {
            bool endApp = false;

            Console.WriteLine("Hello welcome to coding challenge of ...");
            Console.WriteLine("... ... ... ...");
            Console.WriteLine("To end the application please confirm enter 'kill' or empty");
            Console.WriteLine("... ... ... ...");
            Console.WriteLine("Let's starts");

            while (!endApp) {

                Console.Write("Please enter a series of charts. I will determinate if this is balance or not ...");
                string myInput = Console.ReadLine();

                if (myInput != "kill")
                {
                    if (Validator.ContainBrakets(myInput))
                    {
                        bool result = Validator.IsBalance(myInput);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        endApp = false;
                        Console.WriteLine("text null or without brakets. Thank you!!");
                    }
                }
                else {
                    endApp = true;
                    Console.WriteLine("Bye!!");
                }
            }
        }
    }
}