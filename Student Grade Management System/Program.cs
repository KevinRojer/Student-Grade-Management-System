using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade_Management_System
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("########## Grade Manager ##########");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Enter Grades");
            Console.WriteLine("3. Calculate Averages");
            Console.WriteLine("4. Generate Report");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
        }


        static void Main()
        {
            while (true)
            {
                ShowMenu();

                // Ask user for input
                Console.WriteLine("Enter your choice: ");
                string? choice = Console.ReadLine();

                // validate input
                if (string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Invalid input. Please, try again.");
                }
                else if (choice == "1")
                {

                }
                else if (choice == "2")
                {

                }
                else if (choice == "3")
                {

                }
                else if (choice == "4")
                {

                }
                else if (choice == "5")
                {
                    // Exit the while loop
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please, try again.");
                }
                // Print an empty line for readability.
                Console.WriteLine();
            }
            // User has exited the application
            Console.WriteLine("Application Closed.");
        }
    }
}