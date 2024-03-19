using System.Xml.Serialization;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            //Print Menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            //Ask the User for a choice
            Console.WriteLine("Please choose a number from the menu (1, 2, 3, or 4");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine(choice);
            //Console.WriteLine(choice);

            //Print message ussing if statements
            if (choice == 1)
            {
                Console.WriteLine("Creating a new game...");
            }
            else if (choice == 2)
            }
            else if (choice == 3)
            {
            else if(choice == 4)
            }

        }
    }
}