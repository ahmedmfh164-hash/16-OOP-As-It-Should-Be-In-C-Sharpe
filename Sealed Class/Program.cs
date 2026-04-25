using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{

    sealed class clsA
    {
      
    }
                //trying to inherit sealed class
                //Error Code
    class clsB   :clsA
    {
      
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Create object from class
            clsA ObjectA1 = new clsA();
            ObjectA1.Method1();
            ObjectA1.Method2();

            Console.ReadKey();
        }
    }
}
