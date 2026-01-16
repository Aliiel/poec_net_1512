
using DemoEFCore.Data;
using DemoEFCore.Models;
using System.Globalization;

void AddStudent()
{
    Console.WriteLine("\n--- Add Student ---");
    Console.Write("LastName : ");
    string lastname = Console.ReadLine();
    Console.Write("FirstName : ");
    string firstname = Console.ReadLine();
    Console.Write("Classe Number : ");
    int classeNumber = int.Parse(Console.ReadLine());
    Console.Write("Diplome Date (dd-MM-yyyy) : ");
    string diplomeDateStr = Console.ReadLine();

    DateTime date = DateTime.ParseExact(diplomeDateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);

    using (var db = new StudentDbContext())
    {
        Student student = new Student(lastname, firstname, classeNumber, date);

        db.Students.Add(student);
        db.SaveChanges();
    }
}


void ShowAllStudents()
{
    using (var db = new StudentDbContext())
    {
        List<Student> students = new List<Student>();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}



void UpdateStudent()
{
    Console.WriteLine("\n---Update Student ---");
    Console.Write("ID Student : ");
    int id = int.Parse(Console.ReadLine());


    using (var db = new StudentDbContext())
    {

        Student student = db.Students.Find(id);

        if (student == null)
        {
            Console.WriteLine("no student found with this id");
        }

        Console.Write("LastName : ");
        string lastname = Console.ReadLine();
        Console.Write("FirstName : ");
        string firstname = Console.ReadLine();
        Console.Write("Classe Number : ");
        int classeNumber = int.Parse(Console.ReadLine());
        Console.Write("Diplome Date (dd-MM-yyyyy) : ");
        string diplomeDateStr = Console.ReadLine();

        DateTime date = DateTime.ParseExact(diplomeDateStr, "dd-MM-yyyyy", CultureInfo.InvariantCulture);

        student.LastName = lastname;
        student.FirstName = firstname;
        student.ClassNumber = classeNumber;
        student.DiplomeDate = date;

        db.SaveChanges();
    }
}


void DeleteStudent()
{
    Console.WriteLine("\n -- Delete Student -- ");
    Console.Write("Id Student : ");
    int id = int.Parse(Console.ReadLine());

    using (var db = new StudentDbContext())
    {
        Student? student = db.Students.Find(id);

        if (student == null)
        {
            Console.WriteLine("Not found");
            return;
        }

        db.Students.Remove(student);
        db.SaveChanges();

        Console.WriteLine("student deleted");
    }
}


void GetStudentById()
{
    Console.WriteLine("\n -- Delete Student -- ");
    Console.Write("Id Student : ");
    int id = int.Parse(Console.ReadLine());

    using (var db = new StudentDbContext())
    {
        Student student = db.Students.Find(id);

        if (student == null)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            Console.WriteLine(student);
        }
    }
}


void GetStudentByLastName()
{
    Console.WriteLine("\n -- Get Student by lastname -- ");
    Console.Write("name of student : ");

    var lastName = Console.ReadLine();

    using (var db = new StudentDbContext())
    {
        List<Student> students = db.Students.Where(student => student.LastName.Contains(lastName)).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}

AddStudent();
ShowAllStudents();
UpdateStudent();
DeleteStudent();
GetStudentById();
GetStudentByLastName();
