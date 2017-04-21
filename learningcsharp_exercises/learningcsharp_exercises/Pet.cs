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

        //properties - getters and setters - accessor methods
        //encapsulation means to hide implementation
        public int Age
        {
            get { return this.age; }
            set {

                if (value < 0)
                {
                    Console.WriteLine("Input must be greater than 0");
                }

                else if (value >= 26)
                {
                    Console.WriteLine("Wow, is that in human years or dog years!? Please input a number between 0 and 25");
                }

                else
                this.age = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //functions
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
