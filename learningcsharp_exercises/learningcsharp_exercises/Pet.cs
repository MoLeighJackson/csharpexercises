using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningcsharp_exercises
{
    class Pet
    {
       //member date types
        private string color;
        private string breed;
        private int age;
        private int yearAdopted;

        //function
        public void walk()
        {
            Console.WriteLine("Walked outside");
        }

        public void speak()
        {
            Console.WriteLine("Bark");
        }
    }
}
