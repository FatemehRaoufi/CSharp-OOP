using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
    public class Person
    {
        public int Age;
        public string FullName;

        public Person()
        {
        }

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
        public Person Copy()
        {
            return ((Person)this.MemberwiseClone());
        }

        #region ICloneable Members
        public object Clone()
        {
            return (this.MemberwiseClone());
        }
        #endregion

        #region ICloneable Member(s)
        public object Clone1()
        {
            return (this.MemberwiseClone());
        }
        #endregion
    }
    public class Factory : System.ICloneable
    {
        public int EmployeeCount;
        public string FactoryName;
        public Person Manager = null;

        public Factory(string factoryName, int employeeCount, string fullName, int age)
        {
            FactoryName = factoryName;
            EmployeeCount = employeeCount;
            Manager = new Person(fullName, age);
        }

        public Factory ShallowCopy()
        {
            return ((Factory)this.MemberwiseClone()); // Wrap
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Factory Name: {0}\nEmployee Count: {1}\nManager Full Name: {2}\nManager Age: {3}", FactoryName, EmployeeCount, Manager.FullName, Manager.Age);
        }

        #region ICloneable Member(s)
        public object Clone()
        {
            Factory oFactory = (Factory)this.MemberwiseClone();
            oFactory.Manager = (Person)this.Manager.Clone();

            return (oFactory);
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            // Wrong Usage!
            // Person oPerson2 = (Person) oPerson1.Copy(); // Creates a new object that is a copy of the current instance!
            // oPerson2.Age = 30;
        
            Person oPerson1 = new Person("Ali Reza Alavi", 20);
            Person oPerson2 = (Person)oPerson1.Clone();
            oPerson2.Age = 30;

            Person oPerson3 = oPerson1.Copy();

            System.Console.WriteLine("\n----------");
            oPerson1.ShowInfo();
            System.Console.WriteLine("----------");
            System.Console.WriteLine("\n----------");
            oPerson2.ShowInfo();
            System.Console.WriteLine("----------");
            oPerson3.ShowInfo();
            //......................................................

            Factory oFactory1 = new Factory("Iran Khodro", 2000, "Ali Reza Alavi", 20);
            Factory oFactory2 = oFactory1.ShallowCopy();
            oFactory2.Manager.Age = 30;
            oFactory2.EmployeeCount = 3000;
            Factory oFactory3 = (Factory)oFactory1.Clone();
            oFactory3.Manager.Age = 40;
            oFactory3.EmployeeCount = 4000;

            System.Console.WriteLine("\n----------");
            oFactory1.ShowInfo();
            System.Console.WriteLine("----------");
            System.Console.WriteLine("\n----------");
            oFactory2.ShowInfo();
            System.Console.WriteLine("----------");
            System.Console.WriteLine("\n----------");
            oFactory3.ShowInfo();
            System.Console.WriteLine("----------");



            System.Console.ReadLine();
        }
    }
}
