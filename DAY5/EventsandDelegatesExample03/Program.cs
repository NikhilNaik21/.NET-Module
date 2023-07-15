using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDeliEx
{
    public delegate void MyDelegate(int dept);
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Employee employee = new Employee();
                DeptHandler handler = new DeptHandler();

                MyDelegate Fin = new MyDelegate(handler.onFin);
                MyDelegate Mar = new MyDelegate(handler.onMar);
                MyDelegate Hr = new MyDelegate(handler.onHr);
                MyDelegate It = new MyDelegate(handler.onIT);

                employee.Finance += Fin;
                employee.Marketing += Mar;
                employee.HR += Hr;
                employee.IT += It;

                Console.WriteLine("choose Your Department Name 1.Finance 2.Marketing 3.HR 4.IT");
                employee.Dept = Convert.ToInt32(Console.ReadLine());

                Console.ReadLine();
            }
        }
    }
    public class Employee
    {
        public event MyDelegate Finance;
        public event MyDelegate Marketing;
        public event MyDelegate HR;
        public event MyDelegate IT;

        private int _Dept;
        public int Dept
        {
            get { return _Dept; }
            set
            {
                _Dept = value;

                if (_Dept == 1)
                {
                    Finance(_Dept);
                }
                else if (_Dept == 2)
                {
                    Marketing(_Dept);
                }
                else if (_Dept == 3)
                {
                    HR(_Dept);
                }
                else if (_Dept == 4)
                {
                    IT(_Dept);
                }
                else { Console.WriteLine("Invalid Choice"); }

            }
        }
    }


}
public class DeptHandler
{
    public void onFin(int dept)
    {
        Console.WriteLine("You selected Finance Dept");
    }
    public void onMar(int dept)
    {
        Console.WriteLine("You Selected Marketing Dept");
    }
    public void onHr(int dept)
    {
        Console.WriteLine("You selected HR dept");
    }
    public void onIT(int dept)
    {
        Console.WriteLine("You selected IT dept");
    }
}