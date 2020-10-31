using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        /// <summary>
        /// Implementing ArrayList
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            System.Collections.ArrayList oList = new System.Collections.ArrayList();

            System.Console.WriteLine("List count: {0}", oList.Count.ToString());
            System.Console.WriteLine("List capacity: {0}", oList.Capacity.ToString());

            System.Console.WriteLine("\n----------\n");

            oList.Add("Ali Reza Alavi");
            oList.Add("Sara Ahmadi");
            oList.Add("Sanaz Samimi");

            foreach (string strCurrent in oList)
                System.Console.WriteLine(strCurrent);

            System.Console.WriteLine("\n----------\n");

            for (int intIndex = 0; intIndex <= oList.Count - 1; intIndex++)
                System.Console.WriteLine(oList[intIndex].ToString());

            System.Console.WriteLine("\n----------\n");

            oList.Sort();
            System.Console.WriteLine("List count: {0}", oList.Count.ToString());
            System.Console.WriteLine("List capacity: {0}", oList.Capacity.ToString());

            System.Console.WriteLine("\n----------\n");

            oList.TrimToSize();

            System.Console.WriteLine("List count: {0}", oList.Count.ToString());
            System.Console.WriteLine("List capacity: {0}", oList.Capacity.ToString());

            System.Console.WriteLine("\n----------\n");

            oList.Clear();

            foreach (string strCurrent in oList)
                System.Console.WriteLine(strCurrent);

            System.Console.WriteLine("\n----------\n");

            oList.Add("Ali Reza Alavi2");
            oList.Add("Sara Ahmadi2");
            oList.Add("Sanaz Samimi2");

            if (oList.Contains("Dariush Tasdighi"))
                System.Console.WriteLine("List contains Dariush Tasdighi");
            else
                System.Console.WriteLine("List does not contain Dariush Tasdighi");

            if (oList.Contains("Sara Ahmadi2"))
                System.Console.WriteLine("List contains Sara Ahmadi");
            else
                System.Console.WriteLine("List does not contain Sara Ahmadi2");

            System.Console.WriteLine("\n----------\n");

            oList.Clear();

            oList.Add("A");
            oList.Add("B");
            oList.Add("C");
            oList.Add("D");
            oList.Add("E");
            oList.Add("F");
            oList.Add("G");
            oList.Add("H");
            oList.Add("I");
            oList.Add("J");
            oList.Add("B");

            oList.Remove("B");
            oList.RemoveAt(1);

            foreach (string strCurrent in oList)
                System.Console.WriteLine(strCurrent);

            System.Console.WriteLine("\n----------\n");

            oList.Reverse();
            oList.Sort();

            foreach (string strCurrent in oList)
                System.Console.WriteLine(strCurrent);

            System.Console.ReadLine();
        }
    }
}
