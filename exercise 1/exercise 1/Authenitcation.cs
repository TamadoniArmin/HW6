using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace exercise_1;

public class Authenitcation : IAuthenitcation
{
    //Storage currentuser = new Storage();
    //Person currentuser = new Person();
    public bool Login(string Modleusername, string Modlepassword)
    {

        foreach (var item in Storage.Peaple)
        {
            if (item is not null)
            {
                if (item.Username == Modleusername && item.password == Modlepassword)
                {
                    Console.WriteLine($"***** Wellcome {Modleusername} *****");
                    Storage.currentUser = item;
                    return true;
                }
            }
        }
        Console.WriteLine("There is no person with this information in database!");
        return false;
    }
    public bool checkacess(string modleUsername)
    {
        foreach (var person in Storage.Peaple)
        {
            if (person is not null)
            {
                if (person.Username==modleUsername)
                {
                    if (person.Role == RoleEnum.Admin)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public int LastId()
    {
        int counter = 1;
        foreach (var person in Storage.Peaple)
        {
            if (person is not null)
            {
                counter++;
            }
            else
                if (person is null)
            {
                return counter;
            }
        }
        return 0;
    }
    public bool Register(string Email, string password, string Username)
    {
        foreach (var item in Storage.Peaple)
        {
            if (item is not null)
            {
                if (item.Email==Email)
                {
                    Console.WriteLine("This Email is already used!");
                    return false;
                }
                else
                    if (item.Username==Username)
                {
                    Console.WriteLine("This Username is already taken!");
                    return false;
                }
            }
            else
                if (item is null)
            {
                Person person = new Person();
                person.Email = Email;
                person.password = password;
                person.Role = RoleEnum.User;
                person.Id = LastId();
                return true;
            }
        }
        return false;
    }


}
