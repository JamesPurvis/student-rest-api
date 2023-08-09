using System;
namespace StudentApi.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string? Major { get; set; }
	}
}

