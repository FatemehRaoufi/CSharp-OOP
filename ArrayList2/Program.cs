using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList2
{
    public class Person
    {
        public int Age;
        public string FullName;

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
            System.Collections.ArrayList oStringCollection = new System.Collections.ArrayList();

            oStringCollection.Add("Kazem");
            oStringCollection.Add("Ahmad");
            oStringCollection.Add("Sanaz");
            oStringCollection.Add("Babak");

            System.Console.WriteLine("\n----------");
            foreach (string str in oStringCollection)
                System.Console.WriteLine(str);
            System.Console.WriteLine("----------");

            oStringCollection.Sort();

            System.Console.WriteLine("\n----------");
            foreach (string str in oStringCollection)
                System.Console.WriteLine(str);
            System.Console.WriteLine("----------");

            oStringCollection.Clear();

            System.Collections.ArrayList oPersonCollection = new System.Collections.ArrayList();

            oPersonCollection.Add(new Person("Kazem", 30));
            oPersonCollection.Add(new Person("Ahmad", 40));
            oPersonCollection.Add(new Person("Sanaz", 20));
            oPersonCollection.Add(new Person("Babak", 10));

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            // Wrong Usage!
            oPersonCollection.Sort();

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
