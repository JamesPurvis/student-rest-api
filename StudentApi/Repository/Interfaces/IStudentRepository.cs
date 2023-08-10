using System;
using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi.Repository.Interfaces
{
	public interface IStudentRepository
	{
		void CreateStudent(Student student);
		void DeleteStudent(int id);
		void UpdateStudent(Student student);
		Student getStudentById(int id);
		List<Student> returnAllStudents();


	}
}

