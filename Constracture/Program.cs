using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constracture
{
    /// <summary>
    /// Implementing Constructor
    /// </summary>
    public class Person
    {
        public int Age;
        public string FullName;

        //public Person()
        //{
        //    Age = 20;
        //}
        public Person(string fullName)
        {
            FullName = fullName;
        }
        public Person(string fullName, int age)
           : this(fullName)
        {
            Age = age;
        }
    }

    public class Employee : Person
    {
        public int Salary;

        // Wrong Usage!
        //public Employee()
        //{
        //    Salary = 120000;
        //}

        //public Employee(string fullName, int salary)
        //{
        //    FullName = fullName;
        //    Salary = salary;
        //}
        public Employee()
          : base("", 0)
        {
        }
        public Employee(string fullName, int age, int salary)
           : base(fullName, age)
        {
            Salary = salary;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------\n");

            Employee oEmployee1 = new Employee();
            oEmployee1.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            //Employee oEmployee2 = new Employee("Ali Reza Alavi", 200000);
            //oEmployee2.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            Employee oEmployee3 = new Employee("Sara Ahmadi", 30, 300000);
            oEmployee3.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            //...................
            System.Console.WriteLine("\n----------\n");
            
            Employee oEmployee2 = new Employee("Ali Reza Alavi", 20, 20000);
            oEmployee2.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            System.Console.ReadLine();
        }
    }
}
