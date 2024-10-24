using exercise_1;
using System.Security.Cryptography;

//Storage[] books = new Storage[100]
while (true)
{
    Console.Clear();
    Console.WriteLine("******* Wellcome *******");
    Console.Write("Do you have account(+/-) ? ");
    char answeer = Convert.ToChar(Console.ReadLine()!);
    Authenitcation authenitcation = new Authenitcation();
    bool resultofentered;
    bool role;
    if (answeer == '+')
    {
        do
        {
            Console.Write("Please enter your Username: ");
            string EnteredUsername = Console.ReadLine()!;
            Console.Write("Please enter your Password: ");
            string EnteredPassword = Console.ReadLine()!;
            //Authenitcation authenitcation = new Authenitcation();
            resultofentered = authenitcation.Login(EnteredUsername, EnteredPassword);
            role = authenitcation.checkacess(EnteredUsername);
            if (resultofentered)
            {
                break;
            }
            else
                if (!resultofentered)
            {
                Console.WriteLine("The Username or Password that you have entered is not correct!");
                Console.WriteLine("Please try again.");
            }
        } while (!resultofentered);  
        if (resultofentered==true && Storage.currentUser.Role==RoleEnum.Admin)
        {
            AdminMenu();
            //Usermenue();
        }
        else
            if (resultofentered==true && Storage.currentUser.Role==RoleEnum.User)
        {
            Usermenu();
        }
        else
            if (resultofentered==true && Storage.currentUser.Role==RoleEnum.librarian)
        {
            LibrarianMenu();
        }
    }
    else
        if (answeer == '-')
    {
        do
        {
            Console.Write("Please enter an Email: ");
            string enteredemail = Console.ReadLine()!;
            Console.Write("Please enetr your Password: ");
            string enteredpassword = Console.ReadLine()!;
            Console.Write("Please enter your wanted username: ");
            string enteredUsername = Console.ReadLine()!;
            resultofentered = authenitcation.Register(enteredemail, enteredpassword, enteredUsername);
            if (resultofentered)
            {
                Console.WriteLine("Now, Please login.");
                break;
            }
            else
                if (!resultofentered)
            {
                Console.WriteLine("Please enter your asked feld correctly.");
            }
        } while (!resultofentered);
        


    }

}







void AdminMenu()
{
    Console.Clear();
    bool logout = false;
    do
    {
        Console.WriteLine("Please choose one of the iteams blow: ");
        Console.WriteLine("1. If you want to see The list of Users.");
        Console.WriteLine("2. If you want to change someone's role.");
        Console.WriteLine("3. If you want to do something else.");
        Console.WriteLine("4. If you want to logout.");
        int AdminAnsnswer = int.Parse(Console.ReadLine()!);
        switch (AdminAnsnswer)
        {
            case 1:
                if (AdminAnsnswer == 1)
                {
                    Storage.ListofMembers();
                };
                break;
            case 2:
                if (AdminAnsnswer == 2)
                {
                    Console.WriteLine("Please enter the username of User: ");
                    string U = Console.ReadLine()!;
                    Console.WriteLine("Press (1) in order to change users's role to Admin.");
                    Console.WriteLine("press (2) in order to change Admin to normalUser.");
                    int N = int.Parse(Console.ReadLine()!);
                    if (N==1)
                    {
                        Storage.ChangeRole(U, true);
                    }
                    else
                        if (N==2)
                    {
                        Storage.ChangeRole(U, false);
                    }
                };
                break;
            case 3:
                if (AdminAnsnswer == 3)
                {
                    //empty
                };
                break;
            case 4:
                if (AdminAnsnswer == 4)
                {
                    logout = true;
                };
                break;
            default:
                break;
        }
        if (logout)
        {
            Console.WriteLine("***** GoodBye *****");
            break;
        }
    } while (!logout);

}
void Usermenu()
{
    Console.Clear();
    bool logout = false;
    LibraryService libraryService = new LibraryService();
    int choosbook = 0;
    do
    {
        Console.WriteLine("Please choose one of the iteams blow: ");
        Console.WriteLine("1. If you want to see The list of books.");
        //Console.WriteLine("2. If you want to borrow a book.");
        Console.WriteLine("2. If you want to see your borroed list.");
        Console.WriteLine("3. If you want to return a book.");
        Console.WriteLine("4. If you want to do something else.");
        Console.WriteLine("5. If you want to logout.");
        int UserAnsnswer = int.Parse(Console.ReadLine()!);
        switch (UserAnsnswer)
        {
            case 1:
                if (UserAnsnswer == 1)
                {
                    libraryService.GetListOfLibraryBooks();
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Please enter choose one of those books above.");
                    choosbook = int.Parse(Console.ReadLine()!);
                    libraryService.BorrowBook(choosbook, Storage.currentUser.Id);
                };
                break;
            case 2:
                if (UserAnsnswer == 2)
                {
                    libraryService.GetListOfUserBooks(Storage.currentUser.Id);
                };
                break;

            case 3:
                if (UserAnsnswer == 3)
                {
                    libraryService.GetListOfUserBooks(Storage.currentUser.Id);
                    Console.WriteLine("Please choose one of the items above.");
                    choosbook = int.Parse(Console.ReadLine()!);
                    libraryService.ReturnBook(choosbook);
                };
                break;
            case 4:
                if (UserAnsnswer == 4)
                {
                    //empty
                };
                break;
            case 5:
                if (UserAnsnswer == 5)
                {
                    logout = true;
                };
                break;
            default:
                break;
        }
        if (logout)
        {
            Console.WriteLine("***** GoodBye *****");
            break;
        }
    } while (!logout);
}


void LibrarianMenu()
{
    Console.Clear();
    bool logout = false;
    LibrarianService librarianService = new LibrarianService();
    bool result = false;
    do
    {
        Console.WriteLine("Please choose one of the iteams blow: ");
        Console.WriteLine("1. If you want to add a book.");
        Console.WriteLine("2. If you want to search in library.");
        Console.WriteLine("3. If you want to delete a book.");
        Console.WriteLine("4. If you want to see all the books in library.");
        Console.WriteLine("5. If you want to see the list of borrowed books.");
        Console.WriteLine("6. If you want to logout.");
        int librarianananswer = int.Parse(Console.ReadLine()!);
        switch (librarianananswer)
        {
            case 1:
                if (librarianananswer==1)
                {
                    Console.Write("Please enter the name of the book: ");
                    string enterednamebook = Console.ReadLine()!;
                    Console.WriteLine("Please enter the genre of the book: ");
                    Console.WriteLine("1.Cultural");
                    Console.WriteLine("2.sceintific");
                    Console.WriteLine("3.SpeciallizedSports");
                    int enteredgenre = int.Parse(Console.ReadLine()!);
                    result= librarianService.Addbook(enterednamebook, enteredgenre);
                    if (result)
                    {
                        Console.WriteLine("The book has been added succesfully.");
                    }
                    else
                        if (!result)
                    {
                        Console.WriteLine("The procces of adding book faild! Please check the information again.");
                    }
                };
                break;
            case 2:
                if (librarianananswer==2)
                {
                    Console.Write("Please enter the name or part of the name: ");
                    string partofname = Console.ReadLine()!;
                    result = librarianService.CheckByPartOfName(partofname);
                    if (!result)
                    {
                        Console.WriteLine("There is no book in library with this information.");
                    }
                };
                break;
            case 3:
                if (librarianananswer==3)
                {
                    Console.WriteLine("Please chooes one of the items below: ");
                    librarianService.ShowJustNameOfBooks();
                    int answer = int.Parse(Console.ReadLine()!);
                    librarianService.DeleteBook(answer);
                };
                break;
            case 4:
                if (librarianananswer==4)
                {
                    librarianService.ShowAllBookswithinformation();
                };
                break;
            case 5:
                if (librarianananswer==5)
                {
                    librarianService.ShowBorrowedBooks();
                };
                break;
            case 6:
                if (librarianananswer==6)
                {
                    logout = true;
                };
                break;
            default:
                break;
        }
        if (logout)
        {
            Storage.currentUser = null;//*********
            Console.WriteLine("***** Goodbye *****");
            break;
        }
    } while (!logout);

}

