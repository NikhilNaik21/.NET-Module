using OuterNM;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _00DemoBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Minalllll");
            //Console.ReadLine();

            //Class1 obj = new Class1();

            //Console.WriteLine (obj.add(2,3));
            //Console.WriteLine(obj.sub(3, 4));
            //Console.WriteLine(obj.div(5, 5));
            //Console.WriteLine(obj.mult(6, 7));
            //Console.ReadLine();

           CMathLibrary.MyCMath obj = new CMathLibrary.MyCMath();
           int res = obj.add(5, 5);
            int sub=obj.add(5, 5);
            int mult=obj.add(5, 5);
            int div= obj.add(144, 5);
            Console.WriteLine("Addition = "+res + " " + "Substraction= "+sub + " " + "Multiplication= "+mult + " "+ "Division= "+div) ;
            Console.ReadLine();

            #region Outer
            //OuterNM.OuterNm obj = new OuterNM.OuterNm();
            //obj.Test();
            //Console.ReadLine();

            //Class1 obj2 = new Class1();
            //int res=obj2.add(2, 3);
            //Console.WriteLine(res); 
            //Console.ReadLine(); 
            #endregion


        }
    }

}

namespace OuterNM
{
    class OuterNm
    {
        public void Test()
        {
            Console.WriteLine("OuterNM.OuterNm.Test");
        }
    }
}
