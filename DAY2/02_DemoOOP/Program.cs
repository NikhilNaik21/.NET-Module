using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DemoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath mathsobj = new AdvanceMaths();
            mathsobj.Add(3, 3);
            mathsobj.Add(4, 4, 4);
            mathsobj.sub(5, 2);
            mathsobj.mult(6, 3);
            mathsobj.Add(7, 7, 7, 7);

            //CMath cmath = new AdvanceMaths();
            // cmath.Add(3, 3);
            sayHi();
            Console.ReadLine();
        }

   
        static void sayHi()
        {
            Console.WriteLine("Hii");
        }
    }

    class CMath
    {
        public  void  Add(int x , int y)
        {
            Console.WriteLine(x + y);
        }

        public void Add(int x , int y ,int z)
        {
            Console.WriteLine(x + y + z);
        }

        public virtual void sub (int x , int y )
        {
              Console.WriteLine (x - y);
        }

        public virtual void mult(int x, int y)
        {
            Console.WriteLine(x * y);
        }


        public virtual void Add(int x, int y, int z, int u)
        {
            Console.WriteLine (u + x + y + z);
        }

    }

    class AdvanceMaths : CMath
    {
        public override void sub(int x, int y)
        {
           Console.WriteLine(x-y*100);
        }

        public override void mult(int x, int y)
        {
            Console.WriteLine(x * y * 10);
        }

        override
       public  void Add(int x, int y,int z ,int u)
        {
            Console.WriteLine((x + y) + z + u +77);
        }

     

        //hide warning
        public new void Add(int x,int y)
        {
            Console.WriteLine(x + y + 10);
        }
    }
}



