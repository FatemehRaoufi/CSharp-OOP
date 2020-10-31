using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter39
{
    
    public class XEventArgs : System.EventArgs // Before 1th step!
    {
        public int OldAgeValue;
        public int NewAgeValue;

        public XEventArgs(int oldAgeValue, int newAgeValue)
        {
            OldAgeValue = oldAgeValue;
            NewAgeValue = newAgeValue;
        }
    }

    public delegate void XHandler(object sender, XEventArgs e); // 1th step!

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
                onX(new XEventArgs(_age, value)); // 4th step!
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

        protected void onX(XEventArgs e) // 3th step!
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
            oPerson.X += new XHandler(oPerson_X); // 5th step!, Automatically in VS.NET 2003.

            oPerson.Age = 20;
            oPerson.Age = 30;
            oPerson.FullName = "Ali Reza Alavi";

            System.Console.WriteLine("----------");
            oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }

        private static void oPerson_X(object sender, XEventArgs e) // 6th step!
        {
            System.Console.WriteLine("----------");
            System.Console.WriteLine("Old age value: {0}, New age value: {1}", e.OldAgeValue, e.NewAgeValue);
            System.Console.WriteLine("----------");
        }
    }
}

