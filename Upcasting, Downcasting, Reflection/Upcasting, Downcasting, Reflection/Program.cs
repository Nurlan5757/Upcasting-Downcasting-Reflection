using Upcasting__Downcasting__Reflection.Models;

namespace Upcasting__Downcasting__Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("abc", true);
            Cow cow = new Cow("yui");

            Animal[] animals = { lion, cow };

            foreach (var animal in animals)
            {
                if(animal is Lion)
                {
                     
                    Meat meat=new Meat(100,"mal");
                    lion.EatFood(meat);
                    lion.MakeSound();
                    Console.WriteLine(lion.Breed + " " + lion.IsPrideLeader);
                }
                if (animal is Cow)
                {
                    Grass grass = new Grass(50, "yonca");
                    cow.EatFood(grass);
                    cow.MakeSound();
                    cow.ProduceMilk();
                    Console.WriteLine(cow.Breed);
                }
            }

        }
    }
}
