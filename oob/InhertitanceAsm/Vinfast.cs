using System;
using System.ComponentModel.DataAnnotations;
using System.Security;

namespace InhertitanceAsm
{
    public class Vinfast: Car
    {
        public string Color;
        public Vinfast(string carName , int priceCar,string color) : base(carName, priceCar)
        {
            Color = color;
        }

        public void NameCar()
        {
            Console.WriteLine(" Vinfast car" + $"Color: {Color}");
        }
    }

   
}