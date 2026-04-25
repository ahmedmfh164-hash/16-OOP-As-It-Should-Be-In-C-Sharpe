using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class clsCalculator
    {
        private float _LastNumber = 0;
        private float _Result=0;
        private string _LastOperator = "Clear";

        private bool _IsZero(float Number)
        {
                      return (Number == 0);
        }

        public void Add(float Num)
        {
            _LastNumber = Num;
            _Result+=Num;
            _LastOperator="Adding";
        }

        public void Subtract(float Num)
        {
            _LastNumber = Num;
            _Result-=Num;
            _LastOperator="Subtracting";
        }

        public void Multiply(float Num)
        {
            _LastNumber = Num;
            _Result*=Num;
            _LastOperator="Multiplying";

        }

        public bool Divide(float Num)
        {
            bool Succeeded = true;
            _LastOperator="Dividing";

            if(_IsZero(Num))
            {
                _LastNumber=Num;
                _Result/=1;
                Succeeded=false;
            }
            else
            {
                _LastNumber=Num;
                _Result/=Num;
            }

                 return Succeeded;
        }

        public float GetFinalResults()
        {
            return _Result;
        }

        public void Clear()
        {
            _LastNumber = 0;
            _Result = 0;
            _LastOperator="Clear";
        }

        public void PrintResult()
        {
            Console.WriteLine("Result After {0} {1} is :{2}",_LastOperator,_LastNumber,_Result);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator calculator = new clsCalculator();

            calculator.Add(10);
            calculator.PrintResult();

            calculator.Add(100);
            calculator.PrintResult();

            calculator.Subtract(10);
            calculator.PrintResult();

            calculator.Multiply(10);
            calculator.PrintResult();

            calculator.Divide(10);
            calculator.PrintResult();

            calculator.Clear();

        }
    }
}
