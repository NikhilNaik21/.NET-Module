using System;
using System.Diagnostics;

namespace _00DemoOOP_Interface_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Old steps 
            //Senario : we need to develop db operations like Insert, Update, Delete.
            //SQLServer SqlDb = new SQLServer();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("SQL DATABASE");
            //Console.WriteLine("---------------------------");
            //SqlDb.Insert();
            //SqlDb.Update();
            //SqlDb.Delete();

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("MysqlDb DATABASE");
            //Console.WriteLine("---------------------------");
            //MySqlServer MysqlDb = new MySqlServer();
            //MysqlDb.Insert();
            //MysqlDb.Update();
            //MysqlDb.Delete();
            //Console.WriteLine("---------------------------");
            // Console.WriteLine("Oracle DATABASE");
            //Console.WriteLine("---------------------------");
            //OracleServer OracleDb = new OracleServer();

            //OracleDb.Insert();  
            //OracleDb.Update();
            //OracleDb.Delete(); 
            #endregion


            #region Step-1
            //Console.WriteLine("Tell What do you want to call ");
            //Console.WriteLine("1.SQL Server 2.Oracle Server 3.MySql Server ");
            //int choice = Convert.ToInt32(Console.ReadLine()); 

            //do {


            //    switch(choice)
            //        {
            //        case 1:
            //            IDatabase db = new SQLServer();
            //            Console.WriteLine("Tell us what do you want to call:");
            //            Console.WriteLine("1. Insert 2. Update 3. Delete");
            //            int opChoice = Convert.ToInt32(Console.ReadLine());
            //            switch (opChoice)
            //            {
            //                case 1:
            //                    db.Insert();
            //                    break;
            //                case 2:
            //                    db.Update();
            //                    break;
            //                case 3:
            //                    db.Delete();
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid Choice");
            //                    break;
            //            }
            //            break;
            //        case 2:
            //            IDatabase db1 = new OracleServer();
            //            Console.WriteLine("Tell us what do you want to call:");
            //            Console.WriteLine("1. Insert 2. Update 3. Delete");
            //            int opChoice1 = Convert.ToInt32(Console.ReadLine());
            //            switch (opChoice1)
            //            {
            //                case 1:
            //                    db1.Insert();
            //                    break;
            //                case 2:
            //                    db1.Update();
            //                    break;
            //                case 3:
            //                    db1.Delete();
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid Choice");
            //                    break;
            //            }
            //            break;

            //        case 3:
            //            IDatabase db2 = new OracleServer();
            //            Console.WriteLine("Tell us what do you want to call:");
            //            Console.WriteLine("1. Insert 2. Update 3. Delete");
            //            int opChoice2 = Convert.ToInt32(Console.ReadLine());
            //            switch (opChoice2)
            //            {
            //                case 1:
            //                    db2.Insert();
            //                    break;
            //                case 2:
            //                    db2.Update();
            //                    break;
            //                case 3:
            //                    db2.Delete();
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid Choice");
            //                    break;
            //            }
            //            break;
            //    }



            //} while (choice != 0); 
            #endregion








            Console.ReadLine();
        }

    }
       
    //Methods that we want to implement on Server
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();

    }

    //SQL Server
    public class SQLServer : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Deleted from SQL Database");
        }

        public void Insert()
        {
            Console.WriteLine("Inserted into SQL Database");
        }

        public void Update()
        {
            Console.WriteLine("Updated into SQL Database");
        }
    }


    //Factory Class which produces Objects 
    public class DBFactory
    {
        //Factory Method 
        public IDatabase GetDatabse(int choice)
        {
            if (choice == 1)
            {
                return new SQLServer();
            }
            else if (choice == 2)
            {
                return new OracleServer();
            }
            else if (choice == 3)
            {
                return new MySqlServer();
            }
            else
            {
                return null;
            }
        }
    }




    //MySql Server
    public class MySqlServer : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Deleted from MySql Database");
        }

        public void Insert()
        {
            Console.WriteLine("Inserted into MySql Database");

        }

        public void Update()
        {
            Console.WriteLine("Updated into MySql Database");
        }
    }
        //Oracle Server
        public class OracleServer : IDatabase
        {
            public void Delete()
            {
                Console.WriteLine("Deleted from Oracle Database");
            }

            public void Insert()
            {
                Console.WriteLine("Inserted into Oracle Database");
            }

            public void Update()
            {
                Console.WriteLine("Updated into Oracle Database");
            }
        }
    }

