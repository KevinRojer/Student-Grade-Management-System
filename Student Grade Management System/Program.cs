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
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Enter Grades");
            Console.WriteLine("4. Calculate Averages");
            Console.WriteLine("5. Generate Report");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
        }

        static void AddStudent(GradeManager manager)
        {
            Console.WriteLine("Enter student name: ");
            string? name = Console.ReadLine();

            // TODO: Validate only alphabet chars
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name. Please, try gain.");
                return;
            }

            Console.WriteLine("Enter student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int studentID))
            {
                Console.WriteLine("Invalid student ID. Please, try again.");
            }

            Student student = new Student(name, studentID);
            manager.AddStudent(student);
        }

        static void AddCourse(GradeManager manager)
        {
            Console.WriteLine("Enter course name: ");
            string? course = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(course))
            {
                Console.WriteLine("Invalid course name. Please, try again.");
                return;
            }

            Console.WriteLine("Enter instructor name: ");
            string? instructor = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(instructor))
            {
                Console.WriteLine("Invalid input. Please, try again.");
                return;
            }

            Course newCourse = new Course(course, instructor);
            manager.AddCourse(newCourse);
            Console.WriteLine("Course added successfully.");
        }

        static void AddGrades(GradeManager manager)
        {
            Console.WriteLine("Enter student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int studentID))
            {
                Console.WriteLine("Invalid student id. Please, try again.");
                return;
            }

            Console.WriteLine("Enter course: ");
            string? course = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(course))
            {
                Console.WriteLine("Invalid course name. Please, try again.");
                return;
            }

            Console.WriteLine("Enter grade: ");
            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Invalid input for grade. Please, try again.");
                return;
            }

            manager.AddGrade(studentID, course, grade);
        }

        static void CalculateAverages(GradeManager manager)
        {
            manager.ViewStudents();
            Console.WriteLine("Enter student ID: ");

            if (int.TryParse(Console.ReadLine(), out int studentID))
            {
                manager.CalculateAverageGrade(studentID);
            }
            else
            {
                Console.WriteLine("Invalid input. Please, try again.");
            }
        }

        static void GenerateRreport(GradeManager manager)
        {
            if (manager.Students.Count != 0)
            {
                Console.WriteLine("Generating report...");
                Console.WriteLine("---------------------------");
                manager.GenerateReport();
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("No data available. Please, add students.");
            }
            
        }


        static void Main()
        {
            GradeManager manager = new GradeManager();

            while (true)
            {
                ShowMenu();

                Console.WriteLine("Enter your choice: ");
                string? choice = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Invalid input. Please, try again.");
                }
                else if (choice == "1")
                {
                    AddStudent(manager);
                }
                else if (choice == "2")
                {
                    AddCourse(manager);
                }
                else if (choice == "3")
                {
                    AddGrades(manager);
                }
                else if (choice == "4")
                {
                    CalculateAverages(manager);
                }
                else if (choice == "5")
                {
                    GenerateRreport(manager);
                }
                else if (choice == "6")
                {
                    // Exit the while loop
                    Console.WriteLine("Application Closed.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please, try again.");
                }
                // Print an empty line for readability.
                Console.WriteLine();
            }
        }
    }
}