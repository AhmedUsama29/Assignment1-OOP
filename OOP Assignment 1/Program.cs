using System.Security.Cryptography.X509Certificates;

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

            #region Q3: 

            #endregion

        }
    }
}
