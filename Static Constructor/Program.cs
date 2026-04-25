using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
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

        static Settings()
        {
            ProjectPath=@"C:\MyProjects\";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //you cannot create an object here because class is static
            //Settings Obj=new Settings();

            //Read the static Properties

            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);

            //Change the value of the static bool property

            Console.WriteLine(Settings.ProjectPath);

            Console.ReadKey();

        }
    }
}
