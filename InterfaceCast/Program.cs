using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCast
{
    /// <summary>
    /// Implementing Cast in Interface
    /// </summary>
    public interface IPerson
    {
        int Age { get; set; }
        string FullName { get; set; }

        void ShowInfo();
    }

    public class DEmployee : IPerson
    {
        #region Private Field(s)
        private int _age;
        private string _fullName;
        #endregion

        #region Public Field(s)
        public int Days;
        public int PayPerDays;
        #endregion

        #region Constructor(s)
        public DEmployee(string fullName, int age, int days, int payPerDays)
        {
            FullName = fullName;
            Age = age;
            Days = days;
            PayPerDays = payPerDays;
        }
        #endregion

        #region IPerson Members
        public int Age
        {
            get
            {
                return (_age);
            }
            set
            {
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
            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Days * PayPerDays);
        }
        #endregion
    }

    public class HEmployee : IPerson
    {
        #region Private Field(s)
        private int _age;
        private string _fullName;
        #endregion

        #region Public Field(s)
        public int Hours;
        public int PayPerHours;
        #endregion

        #region Constructor(s)
        public HEmployee(string fullName, int age, int hours, int payPerHours)
        {
            FullName = fullName;
            Age = age;
            Hours = hours;
            PayPerHours = payPerHours;
        }
        #endregion

        #region IPerson Members
        public int Age
        {
            get
            {
                return (_age);
            }
            set
            {
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
            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Hours * PayPerHours);
        }
        #endregion
    }

    public class Factory
    {
        public string Name;

        public Factory(string name)
        {
            Name = name;
        }

        public void ShowInformation()
        {
            System.Console.WriteLine("Factory Name: {0}", Name);
        }
    }

    public class Utilities
    {
        public static void ShowInformation(IPerson person)
        {
            person.ShowInfo();
        }

        public static void ShowObjectInformation(object someObject)
        {
            // Manner: 1
            // try
            // {
            // 	   IPerson person = (IPerson) someObject;
            // 	   person.ShowInfo();
            // }
            // catch(System.InvalidCastException ex)
            // {
            //     System.Console.WriteLine(ex.Message);
            // }

            // Manner: 2
            // IPerson person;
            // if(someObject is IPerson)
            // {
            //     person = (IPerson) someObject;
            //     person.ShowInfo();
            // }

            // Manner: 3
            IPerson person = someObject as IPerson;
            if (person != null)
                person.ShowInfo();

            Factory oFactory = someObject as Factory;
            if (oFactory != null)
                oFactory.ShowInformation();
        }
    }

    /// <summary>
    /// Implementing Cast in Interface
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            Factory oFactory1 = new Factory("Iran Khodro");

            DEmployee oEmployee1 = new DEmployee("Ali Reza Alavi", 20, 10, 20000);
            HEmployee oEmployee2 = new HEmployee("Sara Ahmadi", 30, 50, 3000);
            DEmployee oEmployee3 = new DEmployee("Sanaz Samimi", 40, 20, 15000);
            HEmployee oEmployee4 = new HEmployee("Dariush Tasdighi", 50, 60, 12000);

            Utilities.ShowInformation(oEmployee1);
            Utilities.ShowInformation(oEmployee2);
            Utilities.ShowInformation(oEmployee3);
            Utilities.ShowInformation(oEmployee4);

            System.Console.WriteLine("----------");

            Utilities.ShowObjectInformation(oEmployee1);
            Utilities.ShowObjectInformation(oEmployee2);
            Utilities.ShowObjectInformation(oEmployee3);
            Utilities.ShowObjectInformation(oEmployee4);
            Utilities.ShowObjectInformation(oFactory1);

            System.Console.ReadLine();
        }
    }
}
