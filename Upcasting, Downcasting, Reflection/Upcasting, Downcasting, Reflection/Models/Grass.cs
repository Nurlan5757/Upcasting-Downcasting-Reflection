using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection.Models
{
    internal class Grass : Food
    {
        public string Name;

        public Grass(int calorie,string name) : base(calorie)
        {
          Name = name;
        }
    }
}
