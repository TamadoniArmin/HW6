using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace exercise_1;

public static class Storage
{
    public static List<Book> Books = new List<Book>();
    public static List<Person> Peaple = new List<Person>();
    public static Person currentUser { get; set; }
    static Storage()
    {
        Books.Add(new Book { Id = 1, Name = "Tarikhe Iran", Pages = 10,Writer="MR.kk",IsBorrowed=false,genre=GenreEnum.Cultural });
        Books.Add(new Book{ Id = 2, Name = "Dastane rastan", Pages = 288, Writer = "Mr.unknown", IsBorrowed = false,genre=GenreEnum.sceintific });
        Books.Add(new Book { Id = 3, Name = "The old man and the fish", Pages = 38, Writer = "Mr.unknown", IsBorrowed = false,genre=GenreEnum.SpeciallizedSports });
        Peaple.Add(new Person { Id=1,Name = "Armin",Family="Tamadoni",Email="Armin@gmail.com",password="1234",Role=RoleEnum.Admin,Username="Armineee"});
        Peaple.Add(new Person { Id=2,Name = "Amir",Family="mohagheghiyan",Email="Amir@gmail.com",password="133",Role=RoleEnum.User,Username="AmirMo"});
        Peaple.Add( new Person { Id = 3, Name = "Nazanin", Family = "yazdi", Email = "nazy@gmail.com", password = "123", Role = RoleEnum.User, Username = "nazaninnnn" });
        Peaple.Add(new Person { Id = 4, Name = "Arash", Family = "Shahriyii", Email = "Arash@gmail.com", password = "123456", Role = RoleEnum.librarian, Username = "Arashhh" });
    }
    public static void ListofMembers()
    {
        foreach (var person in Peaple)
        {
            if (person is not null)
            {
                Console.WriteLine(person.Username,person.Id,person.Name,person.Family);
                Console.WriteLine("--------------------");
            }
        }
    }
    public static void ChangeRole(string Userneme,bool toAdmin)
    {
        bool check = true;
        foreach (var person in Peaple)
        {
            if (person is not null)
            {
                if (person.Username==Userneme && toAdmin==true)
                {
                    person.Role = RoleEnum.Admin;
                    check = false;
                }
                else
                    if (person.Username==Userneme && toAdmin==false)
                {
                    person.Role = RoleEnum.User;
                    check = false;
                }
                else
                {
                    Console.WriteLine("There is no person with this information is data base!");
                    check = false;
                }
            }
        }
        if (check)
        {
            Console.WriteLine("Error! Please check your entered information.");
        }
    }
    public static void RemoveBook(int BookId)
    {
        foreach (var book in Books)
        {
            if (book is not null)
            {
                if (book.Id==BookId)
                {
                    Books.Remove(book);
                    break;
                }
            }
        }
    }
}
