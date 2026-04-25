using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor_vs_Static_class
{
    /*class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }

        //this is a private constructor to prevent creating object from this class
         private Settings()
         {

         }

    }*/

    static class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }

    

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //You Cannot create an object here because class has private constructor
            //Settings obj=new Settings();

            //Read the static properties

            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
            Console.WriteLine(Settings.ProjectPath);




        }
    }
}
