using ExerciceListeContacts.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceListeContacts.Data
{
    internal class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            string connectionString = "server=localhost;database=db_contact;user=root;password=root;";
            optionbuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
