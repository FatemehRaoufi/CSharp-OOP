using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    /// <summary>
    /// Exception Handling!
    /// </summary>
    public class Utilities
    {
        public static bool Divide1(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch
            {
                z = 0;
                System.Console.WriteLine("Division by zero!");

                return (false);
            }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }

        public static bool Divide2(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch (System.Exception ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                return (false);
            }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }

        public static bool Divide3(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch (System.DivideByZeroException ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                return (false);
            }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }

        public static bool Divide4(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch (System.DivideByZeroException ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                return (false);
            }
            catch (System.Exception ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                return (false);
            }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }

        public static bool Divide5(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch (System.Exception ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                return (false);
            }
            // Wrong Usage!
            // catch(System.DivideByZeroException ex)
            // {
            //     z = 0;
            //     System.Console.WriteLine(ex.Message);
            //
            //     return(false);
            // }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }

        public static bool Divide6(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch (System.DivideByZeroException ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                throw (new System.Exception("DT - Division by zero!"));

                // Wrong Usage!
                // return(false); // Never will be reached!
            }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }

        public static bool Divide7(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch (System.DivideByZeroException ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                throw (new DT_DivideByZeroException("DT - Division by zero!"));

                // return(false); // Never will be reached!
            }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }

        public static bool Divide8(int x, int y, out float z)
        {
            try
            {
                z = x / y;
                System.Console.WriteLine("{0} / {1} = {2}", x, y, z);

                return (true);
            }
            catch (System.DivideByZeroException ex)
            {
                z = 0;
                System.Console.WriteLine(ex.Message);

                throw (new DT_ExtraDivideByZeroException("DT - Division by zero!", x, y));

                // return(false); // Never will be reached!
            }
            finally
            {
                System.Console.WriteLine("Finally will be run anyway!");
            }
        }
    }

    /// <summary>
    /// Exception Class which we created
    /// </summary>
    public class DT_DivideByZeroException : System.ApplicationException
    {
        // public DT_DivideByZeroException(string message)
        // {
        //	Message = message;
        // }

        public DT_DivideByZeroException(string message)
            : base(message)
        {
        }
    }

    /// <summary>
    /// Exception Class which we created
    /// </summary>
    public class DT_ExtraDivideByZeroException : System.ApplicationException
    {
        private int _x;
        private int _y;

        public int X
        {
            get
            {
                return (_x);
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return (_y);
            }
            set
            {
                _y = value;
            }
        }

        public DT_ExtraDivideByZeroException(string message, int x, int y)
            : base(message)
        {
            _x = x;
            _y = y;
        }
    }

    /// <summary>
    /// Implementing Exception
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float c;

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            Utilities.Divide1(a, b, out c);

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            Utilities.Divide2(a, b, out c);

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            Utilities.Divide3(a, b, out c);

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            Utilities.Divide4(a, b, out c);

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            Utilities.Divide5(a, b, out c);

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            try
            {
                Utilities.Divide6(a, b, out c);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            try
            {
                Utilities.Divide7(a, b, out c);
            }
            catch (DT_DivideByZeroException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            System.Console.WriteLine("\n----------");

            System.Console.Write("First Number: ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Second Number: ");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            try
            {
                Utilities.Divide8(a, b, out c);
            }
            catch (DT_ExtraDivideByZeroException ex)
            {
                System.Console.WriteLine(ex.Message + ", X: " + ex.X + ", Y: " + ex.Y);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
