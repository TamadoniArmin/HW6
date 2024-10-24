using System.Security.Principal;
using System.Text;

namespace exercise_1;
public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
    public string Writer { get; set; }
    public bool IsBorrowed { get; set; } = false;
    public int UserId { get; set; }
    public GenreEnum genre { get; set; }
    public DateTime TimeofBorrow { get; set; }
    //public DateTime TimeOfReturn { get; set; }
    public Book()
    {

    }
}
