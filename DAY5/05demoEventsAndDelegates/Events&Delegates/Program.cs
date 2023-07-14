using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _13DemoEventsDelegates
{
    #region Only delegate 
    //public delegate int MyMathDelegate(int p, int q);
    //internal class Program
    //{
    //    delegate void MyDelegate();
    //    static void Main(string[] args)
    //    {
    //        MyDelegate mydel1 = new MyDelegate(SayHi);
    //        mydel1.Invoke();
    //        MyDelegate mydel2 = new MyDelegate(SayBye);
    //        mydel2();

    //        CMath cmathObj =new CMath();

    //        MyMathDelegate mathdel1 = new MyMathDelegate(cmathObj.Add);
    //        int result = mathdel1.Invoke(10, 20);
    //        Console.WriteLine("Add result = "+ result);
    //        Console.ReadLine();
    //    }

    //    static void SayHi()
    //    {
    //        Console.WriteLine("Hi");
    //    }
    //    static void SayBye()
    //    {
    //        Console.WriteLine("Bye");
    //    }
    //}

    //public class CMath
    //{
    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //} 
    #endregion

    public delegate void MyDlegate(int marks);
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            ResultHandler handler = new ResultHandler();

            MyDlegate passDelegate = new MyDlegate(handler.onPass);
            MyDlegate failDelegate = new MyDlegate(handler.onFail);

            student.Pass += passDelegate;
            //controlclassObj.Click    coupling      EventHandler Delegate

            student.Fail += failDelegate;

            Console.WriteLine("Tell us your marks -");
            student.Marks = Convert.ToInt32(Console.ReadLine());

            // student.Result(student.Marks);
            Console.ReadLine();
        }


    }
    public class Student
    {
        public event MyDlegate Pass;
        public event MyDlegate Fail;

        private int _Marks;

        public int Marks
        {
            get { return _Marks; }
            set
            {
                _Marks = value;
                if (_Marks > 40)
                {
                    Pass(_Marks);
                }
                else
                {
                    Fail(_Marks);
                }
            }
        }

        //public void Result(int marks)
        //{
        //    if (marks > 40)
        //    {
        //        Pass(marks);
        //    }
        //    else
        //    {
        //        Fail(marks);
        //    }
        //}



    }

    public class ResultHandler
    {
        public void onPass(int marks)
        {
            Console.WriteLine("Bravo !! you have passed with " + marks + " marks!!!!");
        }
        public void onFail(int marks)
        {
            Console.WriteLine("Bravo !! Amazing!! you have failed with " + marks + " marks!!!!");
        }
    }
}

