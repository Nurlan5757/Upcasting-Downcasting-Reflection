using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection.Models
{
    internal class Lion : Animal
    {
        public bool IsPrideLeader;

        public Lion(string breed, bool isPrideLeader) : base(breed)
        {
            IsPrideLeader=isPrideLeader;
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
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
            Console.WriteLine("Lion Sound");
        }
    }
}
