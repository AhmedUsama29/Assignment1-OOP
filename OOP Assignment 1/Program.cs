using System.Security.Cryptography.X509Certificates;

namespace OOP_Assignment_1
{

    #region Q1

    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            Console.WriteLine("Days of the week are:");

            foreach (WeekDays day  in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }

            #endregion

            #region Q2: 

            #endregion

        }
    }
}
