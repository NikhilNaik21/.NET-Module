// See https://aka.ms/new-console-template for more information


using BasicCal;
using System.Reflection.Metadata.Ecma335;

internal class program
{
    static void Main(String[] args)
    {
        Myclass1 obj = new Myclass1();
        Console.WriteLine("Value of I =" + obj.I);
        MathExample mathExample = new MathExample();
        Console.WriteLine("Multiplication = " + mathExample.Multiply());
    }
}

public class Myclass1
{
    public int I = 10;
}

namespace BasicCal
{
    public class MathExample
    {


        public int Multiply()
        {
            return 10 * 10;
        }
    }
}