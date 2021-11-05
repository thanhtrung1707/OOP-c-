using System;

namespace PolymorphismAsm
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship1 = new Ship();
            ship1.GetInformation();
            Ship battleship = new Battleship("Battleship");
            battleship.GetInformation();
            Overrloading ovr = new Overrloading();
            ovr.GetInfomation("trung");
            Console.ReadLine();

        }
    }
}