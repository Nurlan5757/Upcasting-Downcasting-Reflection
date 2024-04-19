using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection.Models
{
    internal abstract class Animal
    {
        public string Breed;

        protected Animal(string breed)
        {
            Breed = breed;
        }

        public abstract void MakeSound();

        public abstract void EatFood(Food food);
        
    }
}
