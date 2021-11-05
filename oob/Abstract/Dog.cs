using System;

namespace Abstract
{
    public class Dog : Animal
    {

        public override void DogRun()
        {
            Console.WriteLine("Dog is Running....");
        }

        public override void CatRun()
        {
        }
    }
}