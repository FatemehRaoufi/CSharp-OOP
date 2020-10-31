using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// Implementing Inheritance with using ArrayList
    /// </summary>
    public class Person
    {
        public int Age;
        public string FullName;

        public virtual void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    public class DEmployee : Person
    {
        public int Tax;
        public int Days;
        public int PayPerDays;

        public DEmployee(string fullName, int age, int days, int payPerDays, int tax)
        {
            FullName = fullName;
            Tax = tax;
            Age = age;
            Days = days;
            PayPerDays = payPerDays;
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Days * PayPerDays - Tax);
        }
    }

    public class HEmployee : Person
    {
        public int Hours;
        public int PayPerHours;

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

    public class Asghar : Person
    {
        public Asghar(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList oList = new System.Collections.ArrayList();

            DEmployee oDEmployee = new DEmployee("Ali Reza Alavi", 20, 15, 20000, 1000);
            oList.Add(oDEmployee);

            oList.Add(new HEmployee("Sara Ahmadi", 30, 60, 3000));
            oList.Add(new DEmployee("Sanaz Samimi", 40, 18, 12000, 2000));
            oList.Add(new HEmployee("Dariush Tasdighi", 50, 80, 4000));

            oList.Add(new Asghar("Mohammad Ghaderi", 40));

            System.Console.WriteLine("\n----------\n");

            foreach (Person oPerson in oList)
                oPerson.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            for (int intIndex = 0; intIndex <= oList.Count - 1; intIndex++)
            {
                Person oPerson = (Person)oList[intIndex];
                oPerson.ShowInfo();
            }

            System.Console.WriteLine("\n----------\n");

            for (int intIndex = 0; intIndex <= oList.Count - 1; intIndex++)
                ((Person)oList[intIndex]).ShowInfo();

            System.Console.ReadLine();
        }
    }
}
