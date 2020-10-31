using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCast2
{
    /// <summary>
    /// Implementing Cast in Interface
    /// </summary>
    public interface IEmployee
    {
        decimal Salary { get; set; }
        string FullName { get; set; }

        void ShowInfo();
    }

    public class Employee : IEmployee
    {
        #region Private Field(s)
        private decimal _salary;
        private string _fullName;
        #endregion

        #region Constructor(s)
        public Employee(string fullName, decimal salary)
        {
            _salary = salary;
            _fullName = fullName;
        }
        #endregion

        #region IEmployee Member(s)
        public decimal Salary
        {
            get
            {
                return (_salary);
            }
            set
            {
                _salary = value;
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
            System.Console.WriteLine("Full Name: {0}, Salary: {1}", _fullName, _salary);
        }
        #endregion
    }

    public interface ICustomer
    {
        decimal Credit { get; set; }
        string FullName { get; set; }

        void ShowInfo();
    }

    public class Customer : ICustomer
    {
        #region Private Field(s)
        private decimal _credit;
        private string _fullName;
        #endregion

        #region Constructor(s)
        public Customer(string fullName, decimal credit)
        {
            _credit = credit;
            _fullName = fullName;
        }
        #endregion

        #region ICustomer Member(s)
        public decimal Credit
        {
            get
            {
                return (_credit);
            }
            set
            {
                _credit = value;
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
            System.Console.WriteLine("Full Name: {0}, Credit: {1}", _fullName, _credit);
        }
        #endregion
    }

    public class Person : IEmployee, ICustomer
    {
        #region Private Field(s)
        private decimal _salary;
        private decimal _credit;
        private string _fullName;
        #endregion

        public Person()
        {
        }

        public decimal Salary
        {
            get
            {
                return (_salary);
            }
            set
            {
                _salary = value;
            }
        }

        public decimal Credit
        {
            get
            {
                return (_credit);
            }
            set
            {
                _credit = value;
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
            System.Console.WriteLine("Full Name: {0}", _fullName);
        }

        void IEmployee.ShowInfo() // You should not write any access identifier!
        {
            System.Console.WriteLine("Full Name: {0}, Salary: {1}", _fullName, _salary);
        }

        void ICustomer.ShowInfo() // You should not write any access identifier!
        {
            System.Console.WriteLine("Full Name: {0}, Credit: {1}", _fullName, _credit);
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson = new Person();
            oPerson.Salary = 100000;
            oPerson.Credit = 200000;
            oPerson.FullName = "Ali Reza Alavi";

            IEmployee iEmployee = oPerson; // Upcasting!
            ICustomer iCustomer = oPerson; // Upcasting!

            System.Console.WriteLine("\n----------");
            oPerson.ShowInfo();
            System.Console.WriteLine("\n----------");
            iEmployee.ShowInfo();
            System.Console.WriteLine("\n----------");
            iCustomer.ShowInfo();
            System.Console.WriteLine("\n----------");

            System.Console.ReadLine();
        }
    }
}
