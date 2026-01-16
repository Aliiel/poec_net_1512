using DemoEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEFCore.Data
{
    internal class StudentDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) 
        {
            string connectionString = "server=localhost;database=demo_efcore;user=root;password=root;";
            
            optionBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));       
        }

    }
}
