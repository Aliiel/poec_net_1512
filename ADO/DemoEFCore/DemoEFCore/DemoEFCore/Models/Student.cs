using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoEFCore.Models
{
    internal class Student
    {
        public int Id { get; set; }

        [Required] // attribut obligatoire 
        public string LastName { get; set; }

        [StringLength(100)] // limiter le nombre de caractères à 100  
        public string FirstName { get; set; }


        public int ClassNumber { get; set; }


        public DateTime DiplomeDate { get; set; }

        public Student (int id)
        {
            Id = id;

        }

        public Student(string lastName, string firstName, int classNumber, DateTime diplomeDate)
        {
            LastName = lastName;
            FirstName = firstName;
            ClassNumber = classNumber;
            DiplomeDate = diplomeDate;
        }


        public string ToString()
        {
            return $"Student {Id} | Nom : {LastName} {FirstName} | Numéro de classe : {ClassNumber} | Date de diplome : {DiplomeDate} "; 
        }
    }
}
