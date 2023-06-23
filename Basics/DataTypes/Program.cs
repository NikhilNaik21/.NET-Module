// See https://aka.ms/new-console-template for more information
using System;

namespace VariableAndDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Variables and Data Types");
            int i = 10;
            double m = 100.20;
            String str1 = "abde#12$3";
            bool b1 = true;
            Console.WriteLine("Implicit Casting");
             m = Convert.ToDouble(i);
            Console.WriteLine(m);
        }
    }
}
