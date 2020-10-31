using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception2
{
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
                if (value <= 0)
                    throw (new InvalidAgeException(_fullName, _age, value, "DT - Age value must be positive!"));
                else
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

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    public class InvalidAgeException : System.ApplicationException
    {
        private int _oldValue;
        private int _newValue;
        private string _fullName;

        public int OldValue
        {
            get
            {
                return (_oldValue);
            }
        }

        public int NewValue
        {
            get
            {
                return (_newValue);
            }
        }

        public string FullName
        {
            get
            {
                return (_fullName);
            }
        }

        public InvalidAgeException(string fullName, int oldValue, int newValue, string message)
            : base(message)
        {
            _fullName = fullName;
            _oldValue = oldValue;
            _newValue = newValue;
        }
    }

    /// <summary>
    /// پیاده سازی اکسپشن
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson = new Person();
            oPerson.FullName = "Ali Reza Alavi";
            oPerson.Age = 30;

            try
            {
                oPerson.Age = -20;
            }
            catch (InvalidAgeException ex)
            {
                System.Console.WriteLine("----------");
                System.Console.WriteLine("Error on {0} information: ({1})", ex.FullName, ex.Message);
                System.Console.WriteLine("Old Value: {0}, New Value: {1}", ex.OldValue, ex.NewValue);
                System.Console.WriteLine("----------");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
