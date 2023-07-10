using System;
namespace Student_Grade_Management_System
{
	public class GradeManager
	{
		// A class to manage student grades for multiple courses.
		public List<Student> Students { get; set; }
		public List<Course> Courses { get; set; }
		
		public GradeManager()
		{
			Students = new List<Student>();
			Courses = new List<Course>();
		}

		// A method to add students
		public void AddStudent(Student student)
		{
			// Check if student already exist in the school registry
			if (Students.Any(s => s.StudentID == student.StudentID))
			{
				Console.WriteLine("Student already exist in the registry.");
				return;
			}

			// If student does not exist, add the student
			Students.Add(student);
			Console.WriteLine("Successfully added student.");
		}

		// A method to add a course
		public void AddCourse(Course course)
		{
			// Check if course already exist in the registry
			if (Courses.Any(c => c.Name == course.Name && c.Instructor == course.Instructor))
			{
				Console.WriteLine("Course already exists in the registry.");
				return;
			}

			// If course does not exist, add course
			Courses.Add(course);
			Console.WriteLine("Course successfully added to the registry.");
		}

		// A method to retrieve a student by ID
		private Student? GetStudentByID(int studentID)
		{
			foreach (var student in Students)
			{
				if (student.StudentID == studentID)
				{
					return student;
				}
			}

			return null;
		}

		// A method to assign a grade to a student
		public void AddGrade(int studentID, string courseName, double grade)
		{
			// Retrieve the student
			Student? student = GetStudentByID(studentID);

			if (student != null)
			{
				student.AddGrade(courseName, grade);
			}
			else
			{
				Console.WriteLine("Student not found.");
			}
		}

		public void ViewStudents()
		{
			foreach (var student in Students)
			{
                Console.WriteLine("ID: {0} Name: {1}", student.StudentID, student.Name);
			}
		}

		// A method to calculate the average grade for a student
		public void CalculateAverageGrade(int studentID)
		{
			Student? student = GetStudentByID(studentID);

			if (student != null)
			{
                double averageGrade = student.CalculateAverageGrade();
				Console.WriteLine("Avereage grade: {0}", averageGrade);
			}
			else
			{
				Console.WriteLine("Student not found.");
			}
		}

		// A method to generate a report
		public void GenerateReport()
		{
			foreach (var student in Students)
			{
                Console.WriteLine("Student: {0} ID: {1}", student.Name, student.StudentID);
				Console.WriteLine("Grades: ");
				foreach (var grade in student.Grades)
				{
					Console.WriteLine("{0}: {1}", grade.Key, grade.Value);
				}
			}	
		}
	}
}

