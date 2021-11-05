using System;

namespace PolymorphismAsm
{
    public class Battleship : Ship
    {
        public string NameShip;
        public Battleship(string nameShip)
        {
            NameShip = nameShip;
        }
        public override void GetInformation()
        {
            Console.WriteLine("This is the " + NameShip );
        }

    }
} 