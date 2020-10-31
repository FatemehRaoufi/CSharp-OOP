using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// </summary>
    /// Interface:
    ///   1- [interface] is a perfect abstract class.
    ///   2- You should inherit a [interface] from the other [interface].
    ///   3- You should not inherit a [interface] from a [class].
    ///   4- You should inherit a [class] from zero/one [class] and/or one/many [interface].
    ///   5- [interface] does not have any filed(s).
    ///   6- [interface] does not hava any event(s).
    ///   7- [interface] does not hava any constructor.
    ///   8- [interface] members does not have any access modifiyers (public, private, protected...).
    /// </summary>
    public interface IPerson
    {
        #region Member(s)
        #region Property(ies)
        int Age { get; set; }
        string FullName { get; set; }
        #endregion

        #region Method(s)
        void ShowInfo();
        void GetInfo();
        void GetInfo(string fullName, int age);
        #endregion
        #endregion
    }

    /// <summary>
    /// Implementing Interface
    /// </summary>
    public class Person : IPerson
    {
        #region Private Field(s)
        private int _age;
        private string _fullName;
        #endregion

        #region IPerson Members

        public int Age
        {

            get
            {
                return (_age);// TODO:  Add Person.Age getter implementation
            }
            set
            {
                _age = value; // TODO:  Add Person.Age setter implementation
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
                _fullName = value;// TODO:  Add Person.FullName getter implementation
            }
        }



        #region IPerson Members
        public void ShowInfo() // TODO:   Person.ShowInfo implementation
        {
            System.Console.WriteLine("\nFull Name: {0}, Age: {1}\n", _fullName, _age);
        }

        public void GetInfo()  // TODO:   Person.GetInfo implementation
        {
            System.Console.Write("\nFull Name: ");
            _fullName = System.Console.ReadLine();
            System.Console.Write("Age: ");
            _age = System.Convert.ToInt32(System.Console.ReadLine());
        }

        public void GetInfo(string fullName, int age)// TODO:  Add Person.DT_CSHARP_LEARNING.IPerson.GetInfo implementation
        {
            _age = age;
            _fullName = fullName;
        }
        #endregion
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            Person oPerson = new Person();
            oPerson.GetInfo();
            oPerson.ShowInfo();

            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }

    }
}
