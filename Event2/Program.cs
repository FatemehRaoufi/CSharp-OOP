using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter40
{
   
    public class LowAmountEventArgs : System.EventArgs // Before 1th step!
    {
        public string FullName;
        public decimal LowAmount;

        public LowAmountEventArgs(string fullName, decimal lowAmount)
        {
            FullName = fullName;
            LowAmount = lowAmount;
        }
    }

    public delegate void LowAmountHandler(object sender, LowAmountEventArgs e); // 1th step!

    public class Customer
    {
        public decimal Credit;
        public string FullName;

        public Customer(string fullName, decimal credit)
        {
            Credit = credit;
            FullName = fullName;
        }

        public event LowAmountHandler LowAmount; // 2th step!

        protected void onLowAmount(LowAmountEventArgs e) // 3th step!
        {
            if (LowAmount != null)
                LowAmount(this, e);
        }

        public void Buy(decimal amount)
        {
            if (amount > Credit)
            {
                onLowAmount(new LowAmountEventArgs(FullName, amount - Credit));
            }
            else
                Credit -= amount;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Credit: {1}", FullName, Credit);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer oCustomer1 = new Customer("Ali Reza Alavi", 1000);
            oCustomer1.LowAmount += new LowAmountHandler(oCustomer_LowAmount); // 5th step!, Automatically in VS.NET 2003.

            Customer oCustomer2 = new Customer("Sara Ahmadi", 2000);
            oCustomer2.LowAmount += new LowAmountHandler(oCustomer_LowAmount); // Method calling is similar to Customer1!

            oCustomer1.Buy(500);
            oCustomer1.Buy(1000);

            oCustomer2.Buy(5000);
            oCustomer2.Buy(1000);
            oCustomer2.Buy(2000);

            System.Console.ReadLine();
        }

        private static void oCustomer_LowAmount(object sender, LowAmountEventArgs e) // 6th step!
        {
            System.Console.WriteLine("----------");
            System.Console.WriteLine("Full Name: {0}, Low Amount: {1}", e.FullName, e.LowAmount);
            System.Console.WriteLine("----------");
        }

    }
}
