using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Method
{



    internal class Program
    {
        static void Main(string[] args)
        {
            //the code of person class is seperated in 2 files Person1.cs and PersonPrinting.cs
            Person person1=new Person();

            person1.Age=23;
            person1.Birthday();


        }
    }
}
