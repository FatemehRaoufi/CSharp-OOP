using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{
    public delegate void XHandler(object sender, System.EventArgs e); // 1th step!

    public class Person
    {
        private int _age;
        private string _fullName;

        public Person()
        {
        }

        public int Age
        {
            get
            {
                return (_age);
            }
            set
            {
                onX(new System.EventArgs()); // 4th step!
                _age = value;
            }
        }

        public string FullName
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

        public event XHandler X; // 2th step!

        protected void onX(System.EventArgs e) // 3th step!
        {
            if (X != null)
                X(this, e);
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
            Person oPerson = new Person();
            oPerson.X += new XHandler(oPerson_X);

            oPerson.Age = 20;
            oPerson.FullName = "Ali Reza Alavi";

            System.Console.WriteLine("----------");
            oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }

        private static void oPerson_X(object sender, System.EventArgs e) // 6th step!
        {
            System.Console.WriteLine("\n----------");
            System.Console.WriteLine("Age was changed!");
            System.Console.WriteLine("----------");
        }
    }
}
