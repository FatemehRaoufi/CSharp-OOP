using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable2_Enum
{
    public enum Direction
    {
        Ascending,
        Descending
    }

    public class Person : System.IComparable
    {
        public static Direction SortOrder = Direction.Ascending;

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
            if (SortOrder == Direction.Ascending)
            {
                return (Age - ((Person)obj).Age);
                // return(System.String.Compare(FullName, ((Person) obj).FullName));
            }
            else
            {
                return (((Person)obj).Age - Age);
                // return(System.String.Compare(((Person) obj).FullName), FullName);
            }
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

            Person.SortOrder = Direction.Ascending;
            oPersonCollection.Sort();

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            Person.SortOrder = Direction.Descending;
            oPersonCollection.Sort();

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
