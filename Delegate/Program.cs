using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void MyDelegate(int n); // First step: Define your Delegate class!
    public delegate void MyDelegate1();
    public delegate void PersonsFeedBack();

    public class MyClass
    {
        public static void a(int x)
        {
            System.Console.WriteLine("(a) method was run with {0} value!", x);
        }

        public void b(int y)
        {
            System.Console.WriteLine("(b) method was run with {0} value!", y);
        }
        //....................................................
        public static void a1()
        {
            System.Console.WriteLine("(a1) method was run!");
        }

        public void b1()
        {
            System.Console.WriteLine("(b1) method was run!");
        }
        //.......................................
    }
    public class Person
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            MyDelegate oMyDelegate1; // Second Step: Define your Delegate instance!
            oMyDelegate1 = new MyDelegate(MyClass.a); // Third Step: Register some method for your Delegate instance!
            oMyDelegate1(5); // Forth Step: Call your Delegate object!

            System.Console.WriteLine("\n----------");

            MyClass oMyClass1 = new MyClass();
            oMyDelegate1 = new MyDelegate(oMyClass1.b);
            oMyDelegate1(10);

            System.Console.WriteLine("\n----------");

            MyDelegate oMyDelegate2; // Second Step: Define your Delegate instance!

            oMyDelegate2 = new MyDelegate(MyClass.a); // Third Step: Register some method for your Delegate instance!

            MyClass oMyClass2 = new MyClass();
            MyClass oMyClass3 = new MyClass();
            MyClass oMyClass4 = new MyClass();

            oMyDelegate2 += new MyDelegate(oMyClass2.b);
            oMyDelegate2 += new MyDelegate(oMyClass4.b);

            oMyDelegate2(5); // Forth Step: Call your Delegate object!
           
            //............................................................................

            System.Console.WriteLine("\n----------");

            MyDelegate1 oMyDelegate10;
            oMyDelegate10 = new MyDelegate1(MyClass.a1);
            oMyDelegate10();

            System.Console.WriteLine("\n----------");

            MyClass oMyClass10 = new MyClass();
            MyDelegate1 oMyDelegate20;
            oMyDelegate20 = new MyDelegate1(oMyClass10.b1);
            oMyDelegate20();

            System.Console.WriteLine("\n----------");

            MyDelegate1 oMyDelegate30;
            oMyDelegate30 = oMyDelegate10 + oMyDelegate20;
            oMyDelegate30();

            System.Console.WriteLine("\n----------");

            MyDelegate1 oMyDelegate40;
            oMyDelegate40 = oMyDelegate30 - oMyDelegate20;
            oMyDelegate40();

            System.Console.WriteLine("\n----------");

            //.................................................................

            System.Console.WriteLine("\n----------");

            PersonsFeedBack oPersonsFeedBack;

            Person oPerson1 = new Person("Ali Reza Alavi", 20);
            oPersonsFeedBack = new PersonsFeedBack(oPerson1.ShowInfo);

            Person oPerson2 = new Person("Sara Ahmadi", 30);

            Person oPerson3 = new Person("Sanaz Samimi", 40);
            oPersonsFeedBack += new PersonsFeedBack(oPerson3.ShowInfo);

            oPersonsFeedBack();

            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
