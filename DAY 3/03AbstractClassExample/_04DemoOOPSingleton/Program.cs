using System;

namespace _04DemoOOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Senario : we need to develop db operations like Inder, Update, Delete.
            //SQLServer sqlDb = new SQLServer();

            while (true)
            {
                Console.WriteLine("Tell us what do you want to call 1.Sql Server 2.Oracle Server 3. MySql Server");
                int choice = Convert.ToInt32(Console.ReadLine());

                DBFactory factory = new DBFactory();
                IDatabase db = factory.GetDatabse(choice);

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

    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
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
    public class SQLServer : IDatabase
    {
        Logger logger = null;
        public SQLServer()
        {
            logger = Logger.GetLogger();
        }
        public void Insert()
        {
            //100 code
            Console.WriteLine("Data Inserted into SQL Server");
            logger.Log("Insert happened into SQL Server");
        }
        public void Update()
        {
            //100 code
            Console.WriteLine("Data Updated into SQL Server");
            logger.Log("Update happened into SQL Server");
        }
        public void Delete()
        {
            //100 code
            Console.WriteLine("Data Deleted from SQL Server");
            logger.Log("Delete happened into SQL Server");
        }
    }
    public class MySqlServer : IDatabase
    {
        Logger logger = null;
        public MySqlServer()
        {
            logger = Logger.GetLogger();
        }
        public void Delete()
        {
            Console.WriteLine("Data Deleted from MySql Server");
            logger.Log("Delete happened into MySql Server");
        }

        public void Insert()
        {
            Console.WriteLine("Data Inserted into MySql Server");
            logger.Log("Insert happened into MySql Server");
        }

        public void Update()
        {
            Console.WriteLine("Data Updated into MySql Server");
            logger.Log("Update happened into MySql Server");
        }
    }
    public class OracleServer : IDatabase
    {
        Logger logger = null;
        public OracleServer()
        {
            logger = Logger.GetLogger();
        }
        public void Insert()
        {
            //100code
            Console.WriteLine("Data Inserted into Oracle Server");

            logger.Log("Insert happened into Oracle Server");
        }
        public void Update()
        {
            //100code
            Console.WriteLine("Data Updated into Oracle Server");
            logger.Log("Update happened into Oracle Server");
        }
        public void Delete()
        {
            //100code
            Console.WriteLine("Data Deleted from Oracle Server");
            logger.Log("Delete happened into Oracle Server");
        }
    }

    public class Logger
    {
        private static Logger logger = new Logger();
        //private static Logger logger1 = new Logger();
        private Logger()
        {
            // logger class realted initialization you can do it here...
            Console.WriteLine("Logger Object created for the First Time ...");
        }

        public static Logger GetLogger()
        {
            return logger;
        }
        public void Log(string message)
        {
            Console.WriteLine("Logged " + message + " at " + DateTime.Now.ToString());
        }
    }
}
