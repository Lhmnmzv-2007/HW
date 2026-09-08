using HW.Models;

namespace HW;

internal class Program
{
    static void Main(string[] args)
    {
        var context = new LibraryDbConetext();
         context.Students.Add(new Models.Students()
        {
            Firstname = "Ilham",
            Lastname = "Namazov",
            SchoolNumer = 139,
            Gender = Enums.Gender.Male,
            Birthday = new DateTime(2007, 08, 25),
            PhoneNumber = "+994 099 763 10 16",
            DataStatus = Enums.DataStatus.Inserted,
        });

        context.SaveChanges();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("added");
        Console.ResetColor();

        var Student = context.Students.FirstOrDefault(x => x.Id == 1);
        context.Remove<Students>(Student);
        context.SaveChanges();
    }
}
