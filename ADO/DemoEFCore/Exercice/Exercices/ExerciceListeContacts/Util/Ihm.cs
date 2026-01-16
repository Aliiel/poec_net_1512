using ExerciceListeContacts.Data;
using ExerciceListeContacts.Model;
using ExerciceListeContacts.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciceListeContacts.Util
{
    internal class Ihm
    {
        private ContactRepository _contactRepository;

        public Ihm ()
        {
            _contactRepository = new ContactRepository ();
        }


        public void ShowMenu ()
        {
            while (true)
            {
                Console.WriteLine("\n=== Student menu ===");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Show All contacts");
                Console.WriteLine("3. Search contact by ID");
                Console.WriteLine("4. Update contact");
                Console.WriteLine("5. Delete contact");
                Console.WriteLine("0. Exit");
                Console.Write("\nYour choice : ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        ShowAllContacts();
                        break;
                    case "3":
                        GetContactById();
                        break;
                    case "4":
                        UpdateContact();
                        break;
                    case "5":
                        DeleteContact();
                        break;
                    case "0":
                        Console.WriteLine("Au revoir !");
                        return;
                    default:
                        Console.WriteLine("Choix invalide !");
                        break;
                }
            }
        }

        public void AddContact()
        {
            Console.WriteLine("\n--- Add Contact ---");
            Console.Write("LastName : ");
            string? lastname = Console.ReadLine();
            Console.Write("FirstName : ");
            string? firstname = Console.ReadLine();
            Console.Write("Date Of Birth (dd/MM/yyyy) : ");
            string? dateOfBirth = Console.ReadLine();
            Console.Write("Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Gender : ");
            string gender = Console.ReadLine();
            Console.Write("Phone number : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();

            try
            {
                DateTime date = DateTime.ParseExact(dateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Contact contact = new Contact(lastname, firstname, date, age, gender, phoneNumber, email);

                _contactRepository.AddContact(contact);

                if (contact != null)
                {
                    Console.WriteLine("Erreur lors de l'ajout");
                } else
                {
                    Console.WriteLine($"Contact added : {contact} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problème dans la conversion de la date");
            }
        }


        public void ShowAllContacts()
        {
            List<Contact> contacts = _contactRepository.GetAllContacts();

            Console.WriteLine("Contacts recorded : ");

            foreach (Contact contact in contacts)  // foreach (Contact contact in _contactRepository.GetAllContacts();
            {
                Console.WriteLine(contact);
            }
        }


        public void GetContactById()
        {
            Console.Write("Enter contact id : ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                Contact contact = _contactRepository.GetContactById(id);

                if (contact == null)
                {
                    Console.WriteLine("Contact not Found");
                }
                else
                {
                    Console.WriteLine(contact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in getting contact");
            }
        }


        public void UpdateContact()
        {
            Console.Write("Enter contact id : ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                Contact contact = _contactRepository.GetContactById(id);

                if (contact == null)
                {
                    Console.WriteLine("Contact not Found");
                }
                else
                {
                    Console.WriteLine("\n--- Update Contact ---");
                    Console.Write($"LastName : ({contact.LastName})");
                    string? lastname = Console.ReadLine();
                    Console.Write($"FirstName : ({contact.FirstName})");
                    string? firstname = Console.ReadLine();
                    Console.Write($"Date Of Birth (dd/MM/yyyy) : ({contact.DateOfBirth})");
                    string? dateOfBirth = Console.ReadLine();
                    Console.Write($"Age : ({contact.Age})");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write($"Gender : ({contact.Gender})");
                    string gender = Console.ReadLine();
                    Console.Write($"Phone number : ({contact.PhoneNumber})");
                    string phoneNumber = Console.ReadLine();
                    Console.Write($"Email : ({contact.Email})");
                    string email = Console.ReadLine();

                    try
                    {
                        DateTime date = DateTime.ParseExact(dateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Contact ContactToUpdate = new Contact(lastname, firstname, date, age, phoneNumber, gender, email);

                        _contactRepository.UpdateContact(id, ContactToUpdate);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Update contact error !");
                    }       
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in getting contact");
            }
        }


        public void DeleteContact ()
        {
            Console.Write("Enter contact id : ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                _contactRepository.DeleteContactById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in deleting contact");
            } 
        }
    }
}

