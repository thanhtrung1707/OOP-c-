using System;

namespace PolymorphismAsm
{
    public class Overrloading
    {
        public void GetInformation()
        {
            Console.WriteLine("This is the ship");
        }
        public void GetInfomation(string nameShip)
        {
            
            Console.WriteLine("This is the " + nameShip );
        }

    }
}