namespace nezerye
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Heyvan<Eagle> park = new(new Eagle[]
            {
              new Eagle("Shahin"),
              new Eagle("Qartal")
            });
            Heyvan<Bird> park2 = new(new Bird[]
            {
              new Bird("Shahin"),
              new Bird("Qartal")
            });
            Heyvan<Dog> park3 = new(new Dog[]
            {
              new Dog("Alabay"),
              new Dog("Toplan")
            });
            Heyvan<Shark> park4 = new(new Shark[]
            {
              new Shark("Alabay"),
              new Shark("Toplan")
            });

            /*Heyvan<int> nums = Heyvan<int>(new int[] { 1, 2, 3 });*/
        }
    }
    class Heyvan <T> where T : Animal,ISwim, new()
    {
        public T[] Animals { get; private set; }
        class Heyvan(T[] arr)
        {
            Animals = arr;
        }
    }

    class Person
    {

    }
}
