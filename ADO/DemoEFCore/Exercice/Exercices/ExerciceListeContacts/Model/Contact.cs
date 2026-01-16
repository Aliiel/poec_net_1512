using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceListeContacts.Model
{
    internal class Contact
    {
        public int Id {  get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact ()
        {
        }

        public Contact(string firstName, string lastName, DateTime dateOfBirth, int age, string gender, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Age = age;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id contact : {Id} | Name : {FirstName} {LastName} | Date of birth : {DateOfBirth} | Gender : {Gender} | Phone number : {PhoneNumber} | Email : {Email}"; 
        }
    }
}
