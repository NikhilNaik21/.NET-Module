//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _00DemoOOP_Interface_
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            IX obj = new Demo();
//            obj.saHi();

//            IY obj2 = new Demo();
//            obj2.SayBye();

//            Demo obj1 = new Demo();
//            obj1.saHi();
//            obj1.SayBye();

//            Console.ReadLine(); 
//        }
        
//    }

//    interface IX
//    {
//        void saHi();
        
//    }

//    interface IY
//    {
//        void SayBye();
//    }

//    interface Platinum
//    {
//        void SayHi();
//        void SayBye();
//    }

//    class Demo : IX, IY, Platinum
//    {
//        public void saHi()
//        {
//            Console.WriteLine("Hi...");
//        }

//        public void SayBye()
//        {
//            Console.WriteLine("Bye...");
//        }

//        void Platinum.SayBye()
//        {
//            Console.WriteLine("bye...");
//        }

//        void Platinum.SayHi()
//        {
//            Console.WriteLine("Hi...");
//        }
//    }
//}
