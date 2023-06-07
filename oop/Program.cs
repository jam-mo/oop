using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instatnise calculated object
            Calculator calc = new Calculator();
            // create local variables
            int x = 3;
            int y = 3;
            int sum = 0;
            int subtractSum, divideSum, multiplySum = 0;
            sum = calc.Add(x, y);
            subtractSum = calc.Subtract(x, y);
            divideSum = calc.divide(x, y);
            multiplySum = calc.Multiply(x, y);
            Console.WriteLine("sum of {0} + {1} = {2}", x, y, sum);
            Console.WriteLine("sum of {0} - {1} = {2}", x, y, subtractSum);
            Console.WriteLine("sum of {0} / {1} = {2}", x, y, divideSum);
            Console.WriteLine("sum of {0} * {1} = {2}", x, y, multiplySum);
            Console.ReadLine();
        }
    }
}
