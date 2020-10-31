using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable_XML
{
    [System.Serializable]
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
            System.Collections.ArrayList oPersonCollection1 = new System.Collections.ArrayList();

            oPersonCollection1.Add(new Person("Ali Reza Alavi", 20));
            oPersonCollection1.Add(new Person("Sara Ahmadi", 30));
            oPersonCollection1.Add(new Person("Sanaz Samimi", 40));

            System.IO.FileStream oFileStream1 = new System.IO.FileStream(@"C:\TEST.XML", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            // Person Must have Default Constructor!
            System.Xml.Serialization.XmlSerializer oXmlSerializer1 = new System.Xml.Serialization.XmlSerializer(typeof(System.Collections.ArrayList), new System.Type[] { typeof(Person) });
            oXmlSerializer1.Serialize(oFileStream1, oPersonCollection1);
            oFileStream1.Close();
            oPersonCollection1.Clear();

            System.Collections.ArrayList oPersonCollection2 = null;

            System.IO.FileStream oFileStream2 = new System.IO.FileStream(@"C:\TEST.XML", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.Xml.Serialization.XmlSerializer oXmlSerializer2 = new System.Xml.Serialization.XmlSerializer(typeof(System.Collections.ArrayList), new System.Type[] { typeof(Person) });
            oPersonCollection2 = (System.Collections.ArrayList)oXmlSerializer2.Deserialize(oFileStream2);
            oFileStream2.Close();

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection2)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            oPersonCollection2.Clear();

            System.Console.ReadLine();
        }
    }
}
