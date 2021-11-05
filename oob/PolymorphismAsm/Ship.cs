using System;

namespace PolymorphismAsm
{
    public class Ship
    {
        public virtual void  GetInformation()
        {
            Console.WriteLine("This is the ship");
        }
    }
}