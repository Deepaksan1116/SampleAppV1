using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add_two_numbers(5,10));
            Console.WriteLine(Subtract_two_numbers(15,5));
        }
        #region Add two numbers
        public static int Add_two_numbers(int number1,int number2)
        {
            return number1 + number2;
        }
        #endregion

        #region Subtract two numbers
        public static int Subtract_two_numbers(int number1,int number2)
        {
            return number1 - number2;
        }
        #endregion
    }
}
