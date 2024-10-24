using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    public class LibraryService : ILibraryService
    {
        public bool BorrowBook(int idBook, int idUser)
        {
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (book.Id==idBook)
                    {
                        book.IsBorrowed = true;
                        book.UserId = idUser;
                        book.TimeofBorrow = DateTime.Now;
                        return true;

                    }
                }

            }
            return false;
            
        }
        public void ReturnBook(int idBook)
        {
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (book.Id==idBook)
                    {
                        book.IsBorrowed = false;
                        book.UserId = 0;
                    }
                }
            }
        }
        public void GetListOfLibraryBooks()
        {
            int counter = 1;
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (!book.IsBorrowed)
                    {
                        Console.WriteLine(counter +"."+" "+ book.Name);
                        counter++;
                    }
                }
            }
        }
        public void GetListOfUserBooks(int idUser)
        {
            int counter = 1;
            foreach (var book in Storage.Books)
            {
                if (book is not null)
                {
                    if (book.UserId==idUser)
                    {
                        Console.WriteLine(counter+"."+" " +book.Name);
                        counter++;
                    }
                }
            }
        }
    }
}
