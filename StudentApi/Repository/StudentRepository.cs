using System;
using StudentApi.Database;
using StudentApi.Models;

namespace StudentApi.Repository
{
	public class StudentRepository
	{
		public void CreateStudent(Student student)
		{
			using (var context = new DatabaseContext())
			{
				context.students.Add(student);
				context.SaveChanges();
			}
		}

		public void DeleteStudent(int id)
		{
			using (var context = new DatabaseContext())
			{
				var selectedStudent = context.students.Find(id);

				if (selectedStudent != null)
				{
					context.students.Remove(selectedStudent);
					context.SaveChanges();
				}
			}
		}


		public void UpdateStudent(Student student)
		{
			using (var context = new DatabaseContext())
			{
				context.students.Update(student);
				context.SaveChanges();
			}
		}

		public Student getStudentById(int id)
		{
			using (var context = new DatabaseContext())
			{
				return context.students.Find(id);
			}
		}
	}
}

