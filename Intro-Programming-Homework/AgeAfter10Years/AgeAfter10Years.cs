using System;
using System.Globalization;
using System.Threading;
class AgeAfter10Years
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //Tova pomaga na koda da ne se chupi! :)
        Console.Write("Write your Birthday (date.month.year): ");
        DateTime YourBirthDay = DateTime.Parse(Console.ReadLine());
        DateTime TimeNow = DateTime.Today;

        int CurrentAge = TimeNow.Year - YourBirthDay.Year;

        if (TimeNow.Month < YourBirthDay.Month)
        {
            Console.WriteLine("After 10 years you will be {0}", CurrentAge + 9);
        }
        else if (TimeNow.Month == YourBirthDay.Month)
        {
            if (TimeNow.Day > YourBirthDay.Day)
            {
                Console.WriteLine("After 10 years you will be {0}", CurrentAge + 9);
            }
            else if (TimeNow.Day <= YourBirthDay.Day)
            {
                Console.WriteLine("After 10 years you will be {0}", CurrentAge + 10);
            }
        }
        else
        {
            Console.WriteLine("After then years you will be {0}", CurrentAge + 10);
        }
    }
}
