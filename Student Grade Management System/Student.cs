using System;
namespace Student_Grade_Management_System
{
	public class Student
	{
		// A class that represents a student.

		public string Name { get; set; }
		public int StudentID { get; set; }
		public Dictionary<string, double> Grades { get; }

		public Student(string name, int studentID)
		{
			Name = name;
			StudentID = studentID;
			Grades = new Dictionary<string, double>();
		}

		// A method to add a grade
		public void AddGrade(string course, double score)
		{
			Grades[course] = score;
			Console.WriteLine("Grade added successfully.");
		}

		// A method to calculate the average grade
		public double CalculateAverageGrade()
		{
			// Check if grades is not empty
			if (Grades.Count == 0)
			{
				return 0;
			}
			else
			{
				double sum = 0;
				foreach (var grade in Grades.Values)
				{
					// Sum up all the grades
					sum += grade;
				}
				// Calculate the average grade
				return sum / Grades.Count;
			}
		}
	}
}

