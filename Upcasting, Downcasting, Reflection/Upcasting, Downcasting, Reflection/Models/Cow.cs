using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection.Models
{
    internal class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {
        }

        public override void EatFood(Food food)
        {
            if (food is Grass)
            {
                Console.WriteLine("Ugurla qidalandi");
            }
            else
            {
                Console.WriteLine("yanlish qida");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cow Sound");
        }

        public void ProduceMilk() 
        {
            Console.WriteLine("milk produce");
        }
    }
}
