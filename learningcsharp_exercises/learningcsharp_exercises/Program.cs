using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningcsharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Summation(3, 2);
        }

        static void Summation(int firstNum, int secondNum)
        {
            int summation = firstNum + secondNum;
            Console.WriteLine("The Sum is: " + summation);
        }

    }
}
