using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    public delegate void SystemCallback();

    public class SystemCall
    {
        public static void Register(SystemCallback function, int n)
        {
            for (int i = 1; i <= n; i++)
                function();
        }
    }

    public class TestClass1
    {
        public TestClass1()
        {
            SystemCall.Register(new SystemCallback(SomeFunction1), 5);
        }

        public void SomeFunction1()
        {
            System.Console.WriteLine("TestClass1.SomeFunction1 was run by system!");
        }
    }

    public class TestClass2
    {
        public TestClass2()
        {
            SystemCall.Register(new SystemCallback(SomeFunction2), 5);
        }

        public void SomeFunction2()
        {
            System.Console.WriteLine("TestClass2.SomeFunction2 was run by system!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------");

            TestClass1 oTestClass1 = new TestClass1();

            System.Console.WriteLine("----------");

            TestClass2 oTestClass2 = new TestClass2();

            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
