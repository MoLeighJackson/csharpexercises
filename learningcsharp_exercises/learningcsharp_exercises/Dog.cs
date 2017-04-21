using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningcsharp_exercises
{
    class Dog : Pet
    {
        public string name;
        public string petParent;

        public override void Speak()
        {
            Console.WriteLine("Bark, Bark, Bark!");
        }
    }
}
