//Logger class + FileStream ==> Write log in txt file

using System;
using System.IO;

namespace LoggerClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Tell us what do you want to call 1.Sql Server 2.Oracle Server ");
                int choice = Convert.ToInt32(Console.ReadLine());

                DBFactory factory = new DBFactory();
                Database db = factory.GetDatabase(choice);

                Console.WriteLine("Tell us what do you want to call:");
                Console.WriteLine("1. Insert 2. Update 3. Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        db.Insert();
                        break;
                    case 2:
                        db.Update();
                        break;
                    case 3:
                        db.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine();

                if (ynChoice == "n")
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
    }

    public abstract class Database
    {
    protected Logger logger = null;
    public Database()
    {
        logger = Logger.Getlogger();
    }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
         public abstract string GetDatabaseServerName();
        public void Insert() 
    { 
        DoInsert();
        logger.Log("Insert happened into " + GetDatabaseServerName());
    }
        public void Update() { DoUpdate(); logger.Log("Update  happened into " + GetDatabaseServerName()); }
        public void Delete() { DoDelete(); logger.Log("Delete happened into " + GetDatabaseServerName()); }
    }

    //Factory Class wgich produces objects 

    public class DBFactory
    {
        public Database GetDatabase(int choice) 
        { 
            if(choice == 1) { return new SQLServer(); } 
            else if(choice == 2) { return new OracleServer(); }
            else{ return null; }
        }
    }

    public class SQLServer : Database
    {
        public override string GetDatabaseServerName()
        {
            return "SQL Server";
        }

        protected override void DoDelete()
        {
            Console.WriteLine("Data Deleted from SQL Serevr");
           
    }

        protected override void DoInsert()
        {
            Console.WriteLine("Data Inserted into SQL Server");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Data Updated into SQL Server");
        }
    }
    public class OracleServer : Database
    {
        //Logger logger = null;
        //public OracleServer()
        //{
        //   logger = Logger.GetLogger();
        //}
     
        protected override void DoInsert()
        {
            //100code
            Console.WriteLine("Data Inserted into Oracle Server");

        }
        protected override void DoUpdate()
        {
            //100code
            Console.WriteLine("Data Updated into Oracle Server");
        }
        protected override void DoDelete()
        {
            //100code
            Console.WriteLine("Data Deleted from Oracle Server");
        }

        public override string GetDatabaseServerName()
        {
            return "Oracle Server";
        }
    }

    public class Logger
    {
        private static Logger logger = new Logger();

        private  Logger()
        {
            Console.WriteLine("Logger object created for the first time");
        }

        public static Logger Getlogger()
        {
            return logger;
        }

        public void Log(string message)
        {
        FileStream stream = new FileStream(@"D:\Nashik03-04-2023\DOTNET\Log.txt",FileMode.Append , FileAccess.Write);
        StreamWriter writer = new StreamWriter(stream);
        using(writer) {
            writer.WriteLine("Logged " + message + "at " + DateTime.Now.ToString());
        }
            
        }
    }

