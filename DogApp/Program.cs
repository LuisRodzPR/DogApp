using System;

namespace DogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Fred");
            dog.owner = "Bill";
            dog.Bark();
        }
    }
}
