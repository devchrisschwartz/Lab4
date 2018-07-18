using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Display table of squares and cubes from 1 to the number entered by user.

            Console.WriteLine("Learn your squares and cubes here!");
            

            string userChoice = "y";
            while (userChoice.ToLower() == "y" || userChoice.ToLower() == "yes")
            {
                Console.Write("Please enter the biggest integer you want the squares and cubes of: ");
                int userInput = int.Parse(Console.ReadLine());


                string titles = string.Format("{0,-10} {1, -10} {2, -15}", "Number", "Squared", "Cubed");
                Console.WriteLine(titles);
                string separator = string.Format("{0, -10} {1, -10} {2, -15}", "=======", "=======", "======");
                Console.WriteLine(separator);


                for (int number = 1; number <= userInput; number++)
                {
                    string numberTable = string.Format("{0, -10} {1, -10} {2, -15}", number, (number * number), (number * number * number));
                    Console.WriteLine(numberTable);
                }

                Console.Write("Do you want to continue? (Y/N): ");
                userChoice = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
