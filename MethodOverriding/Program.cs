using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    /// <summary>
    /// Implementing MethodOverriding 
    /// 1. Overriding a sample metod: ShowInfo()
    /// 2. Overriding a default C# Method: Tostring()
    /// </summary>
    public class Person
    {
        public int Age;
        public string FullName;

        public virtual void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
        public override string ToString()
        {
            return (FullName);
        }
    }

    public class Employee : Person
    {
        public int Salary;

        public override void ShowInfo() // Method Overriding!
        {
            // base.ShowInfo (); // Auto!

            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Salary);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson1 = new Person();
            oPerson1.Age = 20;
            oPerson1.FullName = "Ali Reza Alavi";
            oPerson1.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            Employee oEmployee1 = new Employee();
            oEmployee1.Age = 30;
            oEmployee1.FullName = "Sara Ahmadi";
            oEmployee1.Salary = 100000;
            oEmployee1.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            Person oPerson2 = oEmployee1; // Object is important!
            oPerson2.ShowInfo();

            ((Employee)oPerson2).Salary = 200000;

            System.Console.WriteLine("\n----------\n");

            //..........................................

            Person oPerson = new Person();
            oPerson.Age = 20;
            oPerson.FullName = "Ali Reza Alavi";
            oPerson.ShowInfo();

            System.Console.WriteLine("\n----------");
            System.Console.WriteLine(oPerson);
            System.Console.WriteLine("----------\n");

            System.Console.WriteLine("----------");
            System.Console.WriteLine(oPerson.ToString());
            System.Console.WriteLine("----------\n");

           

            System.Console.ReadLine();


        }
    }
}
