using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatePractice
{
    public class Program
    {
        public delegate void Bankdelegate(double amt);
        static void Main(string[] args)
        {
            double amt;
           
            Bankdelegate bd = Program.Deposit;
            bd += Program.Reward;
           Console.WriteLine("Enter amount");
            amt = double.Parse(Console.ReadLine());
            bd(amt);

            Console.ReadLine();
        }


        public static double previous_amount = 2378.7;
        public static void Deposit(double new_amount)
        {
            previous_amount += new_amount;
            Console.WriteLine(previous_amount);
        }
        
        public static void Reward(double amt)
        {
            if (amt >= 5000)
            {
                double bonus = 500;
                Console.WriteLine("Bonus Applied "+ " New Amount: "+previous_amount + bonus);
            }
            else 
            {
                Console.WriteLine("No bonus Applied");
            }
        }
       

    }
}
