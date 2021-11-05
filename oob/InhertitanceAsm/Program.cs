using System;

namespace InhertitanceAsm
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("vin",100000);
            c.InfoCar();
            Vinfast vinfast = new Vinfast("VinFast Lux", 100000, "red");
            vinfast.NameCar();
            Console.ReadLine();
        }
    }
}