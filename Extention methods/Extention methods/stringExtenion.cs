

using System.Globalization;

namespace Extention_methods;


public static class stringExtenion
{
    public static DayEnum day { get; set; }
    public static MonthEnum month { get; set; }
    public static bool containstr(this string str, string word)
    {
        if (str.Contains(word) && !string.IsNullOrEmpty(str))
        {
            return true;
        }
        else if (string.IsNullOrEmpty(word))
        {
            return false;
        }
        else
        {
            return false;
        }

    }
    public static bool IsFirstOrNot(this int enteredNumber)
    {
        if (enteredNumber <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= enteredNumber; i++)
        {
            if (enteredNumber % i == 0)
            {
                return false;
            }

        }
        return true;
    }
    public static void ConvertToShamsi(this DateTime dateTime)
    {
        PersianCalendar persianCalendar = new PersianCalendar();
        persianCalendar.GetYear(dateTime);
        int wantedmonth= persianCalendar.GetMonth(dateTime);
        var wantedday= persianCalendar.GetDayOfWeek(dateTime);
        switch (wantedday)
        {
            case DayOfWeek.Saturday: day = DayEnum.شنبه;
                break;
            case DayOfWeek.Sunday: 
                    day = DayEnum.یکشنبه;
                break;
            case DayOfWeek.Monday:
                day = DayEnum.دوشنبه;
                break;
            case DayOfWeek.Tuesday:
                day = DayEnum.سهشنبه;
                break;
            case DayOfWeek.Wednesday:
                day = DayEnum.چهارشنبه;
                break;
            case DayOfWeek.Thursday:
                day = DayEnum.پنجشنبه;
                break;
            case DayOfWeek.Friday:
                day = DayEnum.جمعه;
                break;
            default:
                break;
        }
        switch (wantedmonth)
        {

            case 1:
                if (wantedmonth == 1)
                {
                    month = MonthEnum.فروردین;
                };
                break;
            case 2:
                if (wantedmonth == 2)
                {
                    month = MonthEnum.اردیبهشت;
                };
                break;
            case 3:
                if (wantedmonth == 3)
                {
                    month = MonthEnum.خرداد;
                };
                break;
            case 4:
                if (wantedmonth == 4)
                {
                    month = MonthEnum.تیر;
                };
                break;
            case 5:
                if (wantedmonth == 5)
                {
                    month = MonthEnum.مرداد;
                };
                break;
            case 6:
                if (wantedmonth == 6)
                {
                    month = MonthEnum.شهریور;
                };
                break;
            case 7:
                if (wantedmonth == 7)
                {
                    month = MonthEnum.مهر;
                };
                break;
            case 8:
                if (wantedmonth == 8)
                {
                    month = MonthEnum.آبان;
                };
                break;
            case 9:
                if (wantedmonth == 9)
                {
                    month = MonthEnum.آذز;
                };
                break;
            case 10:
                if (wantedmonth == 10)
                {
                    month = MonthEnum.دی;
                };
                break;
            case 11:
                if (wantedmonth == 11)
                {
                    month = MonthEnum.بهمن;
                };
                break;
            case 12:
                if (wantedmonth == 12)
                {
                    month = MonthEnum.اسفند;
                };
                break;

            default:
                break;
        }
        Console.WriteLine($" Today: {persianCalendar.GetYear(dateTime)} {month} {persianCalendar.GetDayOfMonth(dateTime)}{day} ");

    }
}
