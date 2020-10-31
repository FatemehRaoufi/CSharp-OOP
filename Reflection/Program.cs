using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person
    {
        private int _x;

        public int Age;
        public string FullName;

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public void SetInfo(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public void GetInfo()
        {
            System.Console.WriteLine("Full Name:");
            FullName = System.Console.ReadLine();
            System.Console.Write("Age: ");
            Age = System.Convert.ToInt32(System.Console.ReadLine());
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
            Person oPerson = new Person("Ali Reza Alavi", 20);

            System.Type oType = oPerson.GetType();

            System.Console.WriteLine("\n----------");
            foreach (System.Reflection.MethodInfo oMethodInfo in oType.GetMethods())
            {
                System.Console.WriteLine(oMethodInfo.Name);
                System.Console.WriteLine(" - Parameter(s):");
                foreach (System.Reflection.ParameterInfo oParameterInfo in oMethodInfo.GetParameters())
                    System.Console.WriteLine("     " + oParameterInfo.ParameterType.ToString() + " " + oParameterInfo.Name);
            }
            System.Console.WriteLine("----------");

            System.Console.WriteLine("\n----------");
            foreach (System.Reflection.FieldInfo oFieldInfo in oType.GetFields())
                System.Console.WriteLine(oFieldInfo.Name);
            System.Console.WriteLine("----------");

            System.Console.WriteLine("\n----------");
            foreach (System.Reflection.MethodInfo oMethodInfo in oType.GetMethods())
            {
                if (oMethodInfo.Name == "ShowInfo")
                    oMethodInfo.Invoke(oPerson, null);
            }
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
