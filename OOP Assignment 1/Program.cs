using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace OOP_Assignment_1
{

    #region Q1 Enum

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

    #region Q2 struct

    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    #endregion

    #region Q3 enum

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    #endregion

    #region Q4 enum

    [Flags]
    public enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.


            //foreach (WeekDays day  in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Q2: Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];
            //people[0] = new Person { Name = "Ahmed", Age = 20 };
            //people[1] = new Person { Name = "Kareem", Age = 15 };
            //people[2] = new Person { Name = "Omar", Age = 25 };

            //Console.WriteLine("People details:");
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            #endregion

            #region Q3: Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Write the Season name:");
            //string season = Console.ReadLine();

            //bool flag = Enum.TryParse(season, true, out Season SeasonEnum); //true bec not case sensitive

            //if (flag) {

            //    switch (SeasonEnum) {

            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Season");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season");
            //}


            #endregion

            #region Q4: Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            Permissions permissions = (Permissions)10;

            //current permissions
            Console.WriteLine("Current Permissions: " + permissions);

            // Remove a permission
            permissions ^= Permissions.Write;

            // Add a permission
            permissions ^= Permissions.Read;

            // Display the permissions after
            Console.WriteLine("Permissions after: " + permissions);

            //check
            if ((permissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission exists");
            }
            else
            {
                Console.WriteLine("Read permission does not exist");
            }

            #endregion

        }
    }
}
