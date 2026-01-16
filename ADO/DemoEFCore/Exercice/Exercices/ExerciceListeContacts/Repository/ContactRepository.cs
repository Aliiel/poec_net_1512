using ExerciceListeContacts.Data;
using ExerciceListeContacts.Model;

namespace ExerciceListeContacts.Repository
{
    internal class ContactRepository
    {
        public void AddContact(Contact contact)
        {
            using (var db = new ContactDbContext())
            {
                try
                {
                    db.Contacts.Add(contact);
                    db.SaveChanges();
                    Console.WriteLine("Contact added in bdd !");

                } catch (Exception ex) {
                    Console.WriteLine("");
                }
                
            }
        }


        public List<Contact> GetAllContacts()
        {
            using (var db = new ContactDbContext())
            {
                return db.Contacts.ToList();
            }
        }


        public Contact GetContactById(int id)
        {
            using (var db = new ContactDbContext())
            {
                try
                {
                    Contact contact = db.Contacts.Find(id);
                    return contact;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }


        public void UpdateContact(int id, Contact contact)
        {
            using (var db = new ContactDbContext())
            {
                Contact contactGet = db.Contacts.Find(id);

                if (contactGet == null)
                {
                    Console.WriteLine("Contact not Found");
                }

                foreach (var prop in typeof(Contact).GetProperties())
                {
                    if (prop.Name != "Id" && prop.GetValue(contact) != null)
                    {
                        prop.SetValue(contactGet, prop.GetValue(contact));
                    }
                }

                db.SaveChanges();
                Console.WriteLine("Contact updated ! ");
            }
        }


        public void DeleteContactById(int id)
        {
            using (var db = new ContactDbContext())
            {
                Contact? contact = db.Contacts.Find(id);

                if (contact == null)
                {
                    Console.WriteLine("Contact not Found");
                    return;
                }

                db.Contacts.Remove(contact);
                db.SaveChanges();
                Console.WriteLine("Contact deleted !");
            }
        }
    }
}
