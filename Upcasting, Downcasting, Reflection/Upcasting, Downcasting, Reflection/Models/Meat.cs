using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection.Models
{
    internal class Meat : Food
    {
        public string Type;

        public Meat(int calorie,string type) : base(calorie)
        {
            Type = type;
        }
    }
}
