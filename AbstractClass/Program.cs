using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    /// <summary>
    /// Implementing Sample Abstract Class
    /// </summary>
    public abstract class Person
    {
        public int Age;

        public abstract string FullName { get; set; }
        public abstract void ShowInfo();

        public void ShowAgeAndFullName()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    public class DEmployee : Person
    {
        public int Days;
        public int PayPerDays;

        private string _fullName;

        public override string FullName
        {
            get
            {
                return (_fullName);
            }
            set
            {
                _fullName = value;
            }
        }

        public DEmployee(string fullName, int age, int days, int payPerDays)
        {
            FullName = fullName;
            Age = age;
            Days = days;
            PayPerDays = payPerDays;
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Days * PayPerDays);
        }
    }

    public class HEmployee : Person
    {
        public int Hours;
        public int PayPerHours;

        private string _fullName;

        public override string FullName
        {
            get
            {
                return (_fullName);
            }
            set
            {
                _fullName = value;
            }
        }

        public HEmployee(string fullName, int age, int hours, int payPerHours)
        {
            FullName = fullName;
            Age = age;
            Hours = hours;
            PayPerHours = payPerHours;
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Hours * PayPerHours);
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            // Wrong Usage!
            // You should not create an object from an [abstract] class!
            // Person oPerson = new Person();

            System.Collections.ArrayList oList = new System.Collections.ArrayList();

            DEmployee oDEmployee = new DEmployee("Ali Reza Alavi", 20, 15, 20000);
            oList.Add(oDEmployee);

            oList.Add(new HEmployee("Sara Ahmadi", 30, 60, 3000));
            oList.Add(new DEmployee("Sanaz Samimi", 40, 18, 12000));
            oList.Add(new HEmployee("Dariush Tasdighi", 50, 80, 4000));

            System.Console.WriteLine("\n----------\n");

            foreach (Person oPerson in oList)
                oPerson.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            oDEmployee.ShowAgeAndFullName();

            System.Console.WriteLine("\n----------\n");

            System.Console.ReadLine();
        }
    }
}
