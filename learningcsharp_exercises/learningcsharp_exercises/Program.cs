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
                //string hello = LinkTogether("Hello, ", "World!");
                Console.WriteLine(LinkTogether("Hello,", " World!"));
            }

            string LinkTogether(string firstInput, string secondInput)
            {
                string complete = firstInput + secondInput;
                return complete;
            }

        }
    }
}
