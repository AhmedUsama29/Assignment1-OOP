using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender EmpGender { get; set; }

        public Employee(int _Id, string _Name, SecurityLevel _SecurityLevel, double _Salary, HiringDate _HireDate, Gender _EmpGender)
        {
            Id = _Id;
            Name = _Name;
            SecurityLevel = _SecurityLevel;
            Salary = _Salary;
            HireDate = _HireDate;
            EmpGender = _EmpGender;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: ${Salary}");
            Console.WriteLine($"Hire Date: {HireDate.GetHiringDate()}");
            Console.WriteLine($"Gender: {EmpGender}");
            Console.WriteLine("====================================");
        }

        //Q12
        public override string ToString()
        {
            return System.String.Format("Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nGender: {4}\nHiring Date: {5}",
                                 Id, Name, SecurityLevel, Salary, EmpGender, HireDate.GetHiringDate());
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

        public string GetHiringDate()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }
    //changed in the Employee class

    #endregion

    #region Q10 (Part 2 Q3) : We need to restrict the Gender field to be only M or F [Male or Female] 

    public enum Gender
    {
        M,
        F
    }

    //changed in the Employee class

    #endregion

    #region Q11 (Part 2 Q4): Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    //changed in the Employee class

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

            //Employee emp1 = new Employee(1, "Mai", SecurityLevel.Guest, 15000, new HiringDate(16, 3, 2019), Gender.F);
            //Employee emp2 = new Employee(2, "Ahmed", SecurityLevel.DBA, 75000, new HiringDate(20, 7, 2018), Gender.M);

            ////changed because of Q10 [Hiring Date - Gender - SecurityLevel]

            //Console.WriteLine("Employee 1 Details:");
            //emp1.DisplayEmployeeDetails();

            //Console.WriteLine("Employee 2 Details:");
            //emp2.DisplayEmployeeDetails();

        #endregion

            #region Q9 (Part 2 Q2): Develop a Class to represent the Hiring Date Data : consisting of fields to hold the day, month and Years.

        //HiringDate hiringDate = new HiringDate(29, 4, 2019);

        //    hiringDate.DisplayHiringDate();

        #endregion

            #region Q10 (Part 2 Q3): We need to restrict the Gender field to be only M or F [Male or Female] 

        //Done and changed in the Q8 class , Q8 implementation

        #endregion

            #region Q11 (Part 2 Q4): Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum

        //changed in the Employee class

        #endregion

            #region Q12 (Part 2 Q5): We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]

        //Employee emp3 = new Employee(3,"Omar",SecurityLevel.Developer,19000,new HiringDate(15,6,2020),Gender.M);
        //Console.WriteLine(emp3.ToString()); 

        #endregion

            #region Q13 (Part 2 Q6): Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;) Notes: Implement All the Necessary Member Functions on the Class(Getters, Setters) Define all the Necessary Constructors for the Class Allow NO RUNTIME errors if the user inputs any data Write down all the necessary Properties(Instead of setters and getters)


                Employee[] EmpArr = new Employee[3];

                // there is no security officer in the enum so I will use the secretary
                EmpArr[0] = new Employee(1, "Mariam", SecurityLevel.DBA, 80000, new HiringDate(10, 5, 2015), Gender.F);
                EmpArr[1] = new Employee(2, "Mohamed", SecurityLevel.Guest, 30000, new HiringDate(15, 8, 2018), Gender.M);
                EmpArr[2] = new Employee(3, "Moataz", SecurityLevel.Secretary, 120000, new HiringDate(20, 11, 2016), Gender.M);

                foreach (var emp in EmpArr)
                {
                    Console.WriteLine(emp.ToString());
                    Console.WriteLine("==========================");
                }

            #endregion

        }
    }
}
