using System;
using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi.Database
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.js")
            .Build();

          

            String Username = configuration["AppSettings:Username"];
            String Password = configuration["AppSettings:Password"];
            String Database = configuration["AppSettings:Database"];
            String Host = configuration["AppSettings:Host"];



            string connectionString = "Server=" + Host + ";Database=" + Database + ";User=" + Username + ";Password=" + Password;
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

    }

	
}

