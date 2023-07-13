using System;
using System.Runtime.InteropServices;

namespace _09DemoOOP08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SpellCheckerFactory factor = new SpellCheckerFactory();
            //ISpellChecker checker = factor.GetSpellChecker("gr");

            Notepad notepad1 = new Notepad(null);
            //Notepad notepad1 = new Notepad(null);
            notepad1.SpellCheck();

            HindiSpellChecker hindiSpellChecker = new HindiSpellChecker();
            Notepad notepad2 = new Notepad(hindiSpellChecker);

            notepad2.SpellCheck();


            Console.ReadLine();
        }
    }

    public class HindiSpellChecker : ISpellChecker
    {
        //code here 
        public void DoSpellCheck()
        {
            Console.WriteLine("Hindi spell check done and implemented by our own..");
        }
    }
    public class Notepad
    {
        #region  lang dependent 
        //ISpellChecker _checker= null;
        //SpellCheckerFactory _checkerFactory = new SpellCheckerFactory();
        //public Notepad(string lang)
        //{
        //    if( lang == null) 
        //    {
        //        _checker = _checkerFactory.GetSpellChecker("en");
        //    }
        //    else
        //    {
        //        _checker = _checkerFactory.GetSpellChecker(lang);
        //    }
        //} 
        #endregion

        ISpellChecker _checker = null;
        SpellCheckerFactory _checkerFactory = new SpellCheckerFactory();
        public Notepad(ISpellChecker checker) //Dependency Injection
        {
            if (checker == null)
            {
                _checker = _checkerFactory.GetSpellChecker("en");
            }
            else
            {
                _checker = checker;
            }
        }
        public void SpellCheck()
        {
            _checker.DoSpellCheck();
        }
        public void Cut()
        {
            Console.WriteLine("Cut happened");
        }
        public void Copy()
        {
            Console.WriteLine("Copy happened");
        }
        public void Paste()
        {
            Console.WriteLine("Paste happened");
        }
    }

    public interface ISpellChecker
    {
        void DoSpellCheck();
    }

    public class SpellCheckerFactory
    {
        public ISpellChecker GetSpellChecker(string lang)
        {
            ISpellChecker checker = null;
            switch (lang)
            {
                case "en":
                    checker = new EnglishSpellChecker();
                    break;
                case "gr":
                    checker = new GermanSpellChecker();
                    break;
                case "fr":
                    checker = new FrenchSpellChecker();
                    break;
                default:
                    checker = new EnglishSpellChecker();
                    break;
            }

            return checker;

        }
    }

    public class EnglishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            //imgaine this is huge code block ... and has dependencies on several other components
            //you can conside it as a tiny Project
            Console.WriteLine("Spell Cheker done for English");
        }
    }
    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            //imgaine this is huge code block ... and has dependencies on several other components
            //you can conside it as a tiny Project
            Console.WriteLine("Spell Cheker done for German");
        }
    }
    public class FrenchSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            //imgaine this is huge code block ... and has dependencies on several other components
            //you can conside it as a tiny Project
            Console.WriteLine("Spell Cheker done for French");
        }
    }
}
