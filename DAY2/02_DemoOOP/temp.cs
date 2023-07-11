//using System;
//using System.Security.Cryptography.X509Certificates;

//namespace _03DemoOOP2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            AdvanceMaths mathObj = new AdvanceMaths();
//            mathObj.Add(3, 3);
//            mathObj.Add(4, 4, 4);
//            mathObj.Sub(5, 2);
//            mathObj.Mult(5, 3);
//            //CMath cmath = new AdvanceMaths();
//            // cmath.Add(3, 3);

//            //SayHi();
//            //CMath obj =new CMath();
//            //obj.Add(3,5);
//            //obj.Add(2, 2, 2);
//            Console.ReadLine();
//        }
//        static void SayHi()
//        {
//            Console.WriteLine("HI");
//        }
//    }

//    class CMath
//    {
//        public void Add(int x, int y)
//        {
//            Console.WriteLine(x + y);
//        }
//        public void Add(int x, int y, int z)
//        {
//            Console.WriteLine(x + y + z);
//        }
//        public virtual void Sub(int x, int y)
//        {
//            Console.WriteLine(x - y);
//        }
//        public virtual void Mult(int x, int y)
//        {
//            Console.WriteLine(x * y);
//        }
//    }

//    class AdvanceMaths : CMath
//    {
//        public override void Sub(int x, int y)
//        {
//            Console.WriteLine(x - y * 100);
//        }
//        public override void Mult(int x, int y)
//        {
//            Console.WriteLine(x * y * 10);
//        }
//        public new void Add(int x, int y)
//        {
//            Console.WriteLine(x + y + 10);
//        }
//    }

//}

