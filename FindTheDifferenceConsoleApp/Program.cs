using FindTheDifferenceConsoleApp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDifferenceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Repository class
            Repository rp = new Repository();

            //Set initial values
            int totalNumber = 5;
            int difNumber = 0;
            string userInput = "";
            bool validInt = false;
            
            while (!validInt)
            {
                Console.WriteLine("Please enter a whole number less than 5");
                userInput = Console.ReadLine();
                int result = 0;
                bool parseSuccessful;

                //Check for valid integar
                parseSuccessful = int.TryParse(userInput, out result);

                if (result < 5 && parseSuccessful && result >= 0)
                {
                    try
                    {
                        //Calculate to get difference number
                        difNumber = rp.FindDifference(totalNumber, result);
                        validInt = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an invalid number. Please enter a whole number less than 5");
                }
            }
            Console.WriteLine("The number required to get to " + totalNumber + " is " + difNumber);
        }
    }
}
