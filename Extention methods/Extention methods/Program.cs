using Extention_methods;
using System.Globalization;
using System.Text;
//Console.InputEncoding = Encodig.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Please enter your string: ");
string str = Console.ReadLine()!;
Console.Write("Please enetr the word or phrase: ");
string word = Console.ReadLine()!;
bool result1= stringExtenion.containstr(str, word);
if (result1)
{
    Console.WriteLine("This word is include in your string.");
}
Console.WriteLine("------------------------");
Console.Write("Please enter your number: ");
int entrednumber = int.Parse(Console.ReadLine()!);
bool sresult2= stringExtenion.IsFirstOrNot(entrednumber);
if (sresult2)
{
    Console.WriteLine("This number is First.");
}
else
{
    Console.WriteLine("This number is not first.");
}
Console.WriteLine("------------------------");
Console.Write("Please enter your date: ");
DateTime dateTime = DateTime.Now;
stringExtenion.ConvertToShamsi(dateTime);
