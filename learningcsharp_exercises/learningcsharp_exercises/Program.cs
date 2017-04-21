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
            Dog Chappie = new Dog();
            Chappie.Age = 2;
            Chappie.Speak();
            Chappie.Walk();
        }

    }
}
