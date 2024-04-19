using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection.Models
{
    internal abstract class Food
    {
        public int Calorie;


        protected Food(int calorie)
        {
            Calorie = calorie;
        }
    }
}
