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

            {
                LinkTogether("x", "x");

            }

            void LinkTogether(string firstInput, string secondInput) //void means we aren't returning anything
            {
                string complete = firstInput + secondInput;
                Console.WriteLine(complete);
            }

        }
    }
}
