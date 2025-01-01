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

    #region Q2 & Q7 struct

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

    #region Q5 enum

    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    #endregion

    #region Q6 struct

    public struct Point {

        public int X { get; set; }
        public int Y { get; set; }

        public double DistanceCalc (Point p2)
        {
            
                return Math.Sqrt(Math.Pow(p2.X - X, 2) + Math.Pow(p2.Y - Y, 2));
            
        }

    }


    #endregion

    #region Q8 (Part 2 Q1) : Design and implement a Class for the employees in a company:

    public class  Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string SecurityLevel { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }

        public Employee(int _Id, string _Name, string _SecurityLevel, double _Salary, DateTime _HireDate, string _Gender)
        {
            Id = _Id;
            Name = _Name;
            SecurityLevel = _SecurityLevel;
            Salary = _Salary;
            HireDate = _HireDate;
            Gender = _Gender;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: ${Salary}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine("====================================");
        }



    }

    #endregion

    #region Q9 (Part 2 Q2) : Develop a Class to represent the Hiring Date Data: consisting of fields to hold the day, month and Years.


    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void DisplayHiringDate()
        {
            Console.WriteLine($"Hiring Date: {Day}/{Month}/{Year}");
        }

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

                //Permissions permissions = (Permissions)10;

                ////current permissions
                //Console.WriteLine("Current Permissions: " + permissions);

                //// Remove a permission
                //permissions ^= Permissions.Write;

                //// Add a permission
                //permissions ^= Permissions.Read;

                //// Display the permissions after
                //Console.WriteLine("Permissions after: " + permissions);

                ////check
                //if ((permissions & Permissions.Read) == Permissions.Read)
                //{
                //    Console.WriteLine("Read permission exists");
                //}
                //else
                //{
                //    Console.WriteLine("Read permission does not exist");
                //}

                #endregion

                #region Q5: Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

                //Console.WriteLine("Enter the color:");
                //string color = Console.ReadLine();

                //bool Flag = Enum.TryParse(color, true, out Colors ColorEnum);

                //if (Flag) {

                //    Console.WriteLine($"{color} is a primary color");

                //}
                //else
                //{
                //    Console.WriteLine("Invalid Color or not primary");
                //}

                #endregion

                #region Q6: Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

                //Console.WriteLine("Enter Point 1 (x,y)");
                //Console.WriteLine("X:");
                //int x = int.Parse(Console.ReadLine());
                //Console.WriteLine("Y:");
                //int y = int.Parse(Console.ReadLine());
                //Point point1 = new Point { X = x, Y = y };

                //Console.WriteLine("Enter Point 2 (x,y)");
                //Console.WriteLine("X:");
                //x = int.Parse(Console.ReadLine());
                //Console.WriteLine("Y:");
                //y = int.Parse(Console.ReadLine());
                //Point point2 = new Point { X = x, Y = y };

                //Console.WriteLine($"The Distance Between them is: {point1.DistanceCalc(point2)}");


                #endregion

                #region Q7: Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

                //Person[] persons = new Person[3];

                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine($"Enter details for Person {i + 1}:");

                //    Console.Write("Name: ");
                //    persons[i].Name = Console.ReadLine();

                //    Console.Write("Age: ");
                //    persons[i].Age = int.Parse(Console.ReadLine());
                //}

                //Person oldestPerson = persons[0];
                //for (int i = 1; i < 3; i++)
                //{
                //    if (persons[i].Age > oldestPerson.Age)
                //    {
                //        oldestPerson = persons[i];
                //    }
                //}

                //Console.WriteLine($"\nThe oldest person is {oldestPerson.Name}");

                #endregion

                #region Q8 (Part 2 Q1) : Design and implement a Class for the employees in a company:

                //Employee emp1 = new Employee(1, "Mai", "High", 15000, new DateTime(2015, 3, 15), "Female");
                //Employee emp2 = new Employee(2, "Ahmed", "Medium", 75000, new DateTime(2018, 7, 20), "Male");

                //Console.WriteLine("Employee 1 Details:");
                //emp1.DisplayEmployeeDetails();

                //Console.WriteLine("Employee 2 Details:");
                //emp2.DisplayEmployeeDetails();

                #endregion

                #region Q9: Develop a Class to represent the Hiring Date Data: consisting of fields to hold the day, month and Years.

                HiringDate hiringDate = new HiringDate(29, 4, 2019);

                hiringDate.DisplayHiringDate();

                #endregion

            }
    }
}
