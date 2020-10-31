using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    public class Person : System.IComparable
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

        #region IComparable Members
        public int CompareTo(object obj)
        {
            return (Age - ((Person)obj).Age); // Ascending.
            // return(((Person) obj).Age - Age); // Descending.
            // return(System.String.Compare(FullName, ((Person) obj).FullName)); // Ascending.
            // return(System.String.Compare(((Person) obj).FullName, FullName)); // Descending.
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList oPersonCollection = new System.Collections.ArrayList();

            oPersonCollection.Add(new Person("Kazem", 30));
            oPersonCollection.Add(new Person("Ahmad", 40));
            oPersonCollection.Add(new Person("Sanaz", 20));
            oPersonCollection.Add(new Person("Babak", 10));

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            oPersonCollection.Sort();

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
