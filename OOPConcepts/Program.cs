using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    /// <summary>
    /// پیاده سازی انواع کست در کلاس ها
    /// Implementing Different Type of Cast in Classes
    /// </summary>
    public class Person
    {
        public int Age;
        public string FullName;

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    public class Employee : Person
    {
        public int Salary;
    }


    
    class Program
    {
        static void Main(string[] args)
        {
            Employee oEmployee = new Employee();

            oEmployee.Age = 20;
            oEmployee.FullName = "Ali Reza Alavi";
            oEmployee.Salary = 100000;
            oEmployee.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            Person oPerson = oEmployee; // Up Casting!
            //Person oPerson_02 = new Person();
            oPerson.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            Employee oEmployee1 = (Employee)oPerson; // Down Casting!
            oEmployee1.ShowInfo();
            System.Console.WriteLine("Salary: {0}", oEmployee1.Salary);

            System.Console.WriteLine("\n----------\n");

            // Wrong Usage!
            //Person oPerson1 = new Person();
            //oPerson1.Age = 30;
            //oPerson1.FullName = "Sara Ahmadi";

            //Employee oEmployee2 = (Employee)oPerson1;
            //oEmployee2.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
