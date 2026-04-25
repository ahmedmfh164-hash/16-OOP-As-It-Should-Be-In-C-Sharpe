using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class clsA
    {
        public int x1;
        //x2 is shared for all object because it's on the class level
        public static int x2;

        public int Method1()
        {
            //not static methods can always access the static members
            return x1+x2;
        }

        public static int Method2()
        {
            //static methods cannot access non-static members because there is no object
            //static methods are called at the class level
            //return clsA.x1+x2;
            return x2;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsA obj1 = new clsA();
            clsA obj2 = new clsA();

            obj1.x1 = 7;
            obj2.x1 = 10;
            //x2 is shared for all object because it's on the class level,you can access
            //using the class name.
            clsA.x2=100;

            //you cannot be access by object
            //obj1.x2=100;

            Console.WriteLine("obj1.x1:={0}", obj1.x1);
            Console.WriteLine("obj2.x1:={0}", obj2.x1);
            Console.WriteLine("obj1.method1 results:={0}", obj1.Method1());
            Console.WriteLine("obj2.method1 results:={0}", obj2.Method1());

            //Method2 cannot be accessed through object,only through the class itself.
            //Console.WriteLine(obj1.Method2());

            Console.WriteLine("static Method2 results:={0}", clsA.Method2());
            Console.WriteLine("static x2:={0}", clsA.x2);
        }
    }
}
