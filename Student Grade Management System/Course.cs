using System;

namespace Student_Grade_Management_System
{
	public class Course
	{
		// A class that represents the results of a course.
		public string Name { get; set; }
		public string Instructor { get; set; }
		public List<Student> EnrolledStudents { get; }

		public Course(string courseName, string instructorName)
		{
			Name = courseName;
			Instructor = instructorName;
			EnrolledStudents = new List<Student>();
		}

		// A method to add a student to a course
		public void AddStudent(Student student)
		{
			// Check if student is already registered to the course
			if (EnrolledStudents.Any(s => s.StudentID == student.StudentID))
			{
				Console.WriteLine("The student is already registered for the course.");
				return;
			}

			// If not, register the student for the course
			EnrolledStudents.Add(student);
			Console.WriteLine("Student has been registered for the course.");
		}

		// A method to generate a report for the course
		public void GenerateReport()
		{
			for (int i = 0; i <= EnrolledStudents.Count(); i++)
			{
				// Print a student's name and average grade
				Console.WriteLine("Student: {0}", EnrolledStudents[i].Name);
				Console.WriteLine("Average Grade: {0}\n", EnrolledStudents[i].CalculateAverageGrade());
			}
		}
	}
}

