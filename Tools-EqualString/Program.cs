using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_EqualString
{
    /// <summary>
    /// Implementing Equals String with OOP:
    /// strTemp1.Equals(strTemp2)
    /// oPerson1.Equals(oPerson2)
    /// And using Array List
    /// </summary>
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
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            string strTemp1 = "Ali";
            string strTemp2 = "Ali";
            string strTemp3 = "Reza";

            if (strTemp1.Equals(strTemp2))
                System.Console.WriteLine(strTemp1 + " is equal to " + strTemp2);
            else
                System.Console.WriteLine(strTemp1 + " is not equal to " + strTemp2);

            if (strTemp1.Equals(strTemp3))
                System.Console.WriteLine(strTemp1 + " is equal to " + strTemp3);
            else
                System.Console.WriteLine(strTemp1 + " is not equal to " + strTemp3);

            Person oPerson1 = new Person();
            oPerson1.Age = 20;
            oPerson1.FullName = "Ali Reza Alavi";

            Person oPerson2 = new Person();
            oPerson2.Age = 20;
            oPerson2.FullName = "Ali Reza Alavi";

            Person oPerson3 = new Person();
            oPerson3.Age = 30;
            oPerson3.FullName = "Ali Reza Alavi";

            System.Console.WriteLine("\n----------");
            if (oPerson1.Equals(oPerson2))
                System.Console.WriteLine("oPerson1 is equal to oPerson2");
            else
                System.Console.WriteLine("oPerson1 is not equal to oPerson2");
            System.Console.WriteLine("----------");

            System.Console.WriteLine("----------");
            if (oPerson1.Equals(oPerson3))
                System.Console.WriteLine("oPerson1 is equal to oPerson3");
            else
                System.Console.WriteLine("oPerson1 is not equal to oPerson3");
            System.Console.WriteLine("----------\n");

            System.Collections.ArrayList oCollection = new System.Collections.ArrayList();

            oCollection.Add(new Person("Ali Reza Alavi", 20));
            oCollection.Add(new Person("Sara Ahmadi", 30));
            oCollection.Add(new Person("Sanaz Samimi", 40));

            oCollection.Remove(new Person("Ali Reza Alavi", 20));

            foreach (Person oPerson in oCollection)
                oPerson.ShowInfo();

            oCollection.Clear();

            System.Console.ReadLine();
        }
    }
}
