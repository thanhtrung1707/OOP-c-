using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.DogRun();
            Animal cat = new Cat();
            cat.CatRun();
            Console.ReadLine();
        }
    }
}