using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    public interface ILibraryService
    {
        public bool BorrowBook(int idBook, int idUser);
        public void ReturnBook(int idBook);
        public void GetListOfLibraryBooks();
        public void GetListOfUserBooks(int idUser);
    }
}
