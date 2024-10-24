using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    public class LibrarianService
    {
        public bool Addbook(string modelnameofbook, int genre)
        {
            //bool exist = false;
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (book.Name==modelnameofbook)
                    {
                        Console.WriteLine("This book is already existed!");
                        return false;
                    }
                }
            }
            Book book1 = new Book();
            book1.Name = modelnameofbook;
            if (genre == 1)
            {
                book1.genre = GenreEnum.Cultural;
            }
            else
                if (genre == 2)
            {
                book1.genre = GenreEnum.sceintific;
            }
            else
                if (genre == 3)
            {
                book1.genre = GenreEnum.SpeciallizedSports;
            }
            return true;
        }
        public bool CheckByPartOfName(string partofname)
        {
            int counter = 1;
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (book.Name.Contains(partofname))
                    {
                        Console.WriteLine(counter+")");
                        Console.Write("Name: ");
                        Console.WriteLine(book.Name);
                        Console.Write("Name of writer: ");
                        Console.WriteLine(book.Writer);
                        Console.Write("existing in library: ");
                        Console.WriteLine(book.IsBorrowed);
                        if (book.IsBorrowed)
                        {
                            Console.Write("This book has borrowed by: ");
                            foreach (var user in Storage.Peaple)
                            {
                                if (user is not null)
                                {
                                    if (user.Id==book.UserId)
                                    {
                                        Console.WriteLine(user.Username);
                                    }
                                }
                            }
                        }
                        return true;
                    }
                }
            }
            return false;
        }
        public bool DeleteBook(int choosebook)
        {
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (choosebook==1)
                    {
                        Storage.RemoveBook(1);
                    }
                    else
                        if (choosebook==2)
                    {
                        Storage.RemoveBook(2);
                    }
                    else
                        if (choosebook==3)
                    {
                        Storage.RemoveBook(3);
                    }
                    /*
                     * if (book is not null)
                {
                    Storage.Books.Remove(choosebook);
                    return true;
                }*/
                    return true;
                }
            }
            return false;
        }
        public void ShowJustNameOfBooks()
        {
            int counter = 1;
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    Console.WriteLine(counter+"."+ book.Name);
                    counter++;
                    Console.WriteLine("--------------------------");
                }
            }
        }

        public void ShowAllBookswithinformation()
        {
            int counter = 1;
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    Console.WriteLine(counter + ")");
                    Console.Write("Name: ");
                    Console.WriteLine(book.Name);
                    Console.Write("Name of writer: ");
                    Console.WriteLine(book.Writer);
                    Console.Write("existing in library: ");
                    Console.WriteLine(book.IsBorrowed);
                    if (book.IsBorrowed)
                    {
                        Console.Write("This book has borrowed by: ");
                        foreach (var user in Storage.Peaple)
                        {
                            if (user is not null)
                            {
                                if (user.Id == book.UserId)
                                {
                                    Console.WriteLine(user.Username);
                                }
                            }
                        }
                    }
                    counter++;
                    Console.WriteLine("--------------------------");

                }
            }
        }
        public void ShowBorrowedBooks()
        {
            int counter = 1;
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (book.IsBorrowed)
                    {
                        Console.WriteLine(counter+")");
                        Console.WriteLine("Name: "+ book.Name);
                        Console.WriteLine("This book has borrowed by: "+book.UserId);
                        counter++;

                    }
                }
            }
        }
    }
}
