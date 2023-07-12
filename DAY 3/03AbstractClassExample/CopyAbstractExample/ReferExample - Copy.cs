using System;

namespace _06DemoOOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region old 
            //PDF pdf = new PDF();
            //pdf.Validate();
            //pdf.Parse();
            //pdf.Save();

            //DOCX docx =new DOCX();
            //docx.Save();
            //docx.Parse();
            //docx.Validate(); 
            #endregion

            //PDF obj =new PDF();
            //Report obj1 = new PDF();

            Console.WriteLine("Tell us what do you want to do 1.PDF, 2.DOCX, 3.TXT , 4. XML , 5. JSON");
            int choice = Convert.ToInt32(Console.ReadLine());
            ReportFactory factory = new ReportFactory();
            Report report = factory.GetReport(choice);

            report.CallMethods();


            Console.ReadLine();
        }
        #region first approach 
        //static void ParsePDF()
        //{
        //    //300 lines code 
        //    Console.WriteLine("PDF Parsed");
        //}
        //static void ValidatePDF()
        //{
        //    Console.WriteLine("PDF Validated");
        //}
        //static void SavePDF()
        //{
        //    Console.WriteLine("PDF Saved");
        //} 
        #endregion
    }
    public class ReportFactory
    {
        public Report GetReport(int choice)
        {
            Report report = null;
            if (choice == 1)
            {
                report = new PDF();
                return report;
            }
            else if (choice == 2)
            {
                report = new DOCX();
                return report;
            }
            else if (choice == 3)
            {
                report = new TXT();
                return report;
            }
            else if (choice == 4)
            {
                report = new XML();
                return report;
            }
            else if(choice == 5)
            {
                report = new JSON();
                return report;  
            }
            else
            {
                return null;
            }
        }
    }
    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void CallMethods()
        {
            Parse();
            Validate();
            Save();
        }
    }
    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();
        public override void CallMethods()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }

    public abstract class specialReport2 : Report
    {
        protected abstract void Access();

        public override void CallMethods()
        {
            Access();
            Parse();
            Validate();
            Save();
        }

    }
    public class JSON : specialReport2
    {
     
        protected override void Access()
        {
            Console.WriteLine("Access Allowed..");
        }

        protected override void Parse()
        {
            Console.WriteLine("JSON Parsed");
        }

        protected override void Save()
        {
            Console.WriteLine("JSON Saved");
        }

        protected override void Validate()
        {
            Console.WriteLine("JSON Validated");
        }
    }
    public class XML : SpecialReport
    {
        protected override void Validate()
        {
            Console.WriteLine("XML Validated");
        }
        protected override void Parse()
        {
            Console.WriteLine("XML Parsed");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("XML ReValidated");
        }
        protected override void Save()
        {
            Console.WriteLine("XML Saved");
        }
    }
    public class PDF : Report
    {
        protected override void Parse()
        {
            //300 lines code 
            Console.WriteLine("PDF Parsed");

        }
        protected override void Validate()
        {
            Console.WriteLine("PDF Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
        }
    }
    public class DOCX : Report
    {
        protected override void Parse()
        {
            //300 lines code 
            Console.WriteLine("DOCX Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("DOCX Saved");
        }
    }
    public class TXT : Report
    {
        protected override void Parse()
        {
            //300 lines code 
            Console.WriteLine("TXT Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("TXT Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("TXT Saved");
        }
    }
}