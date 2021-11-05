using System;

namespace InhertitanceAsm
{
    public class Car
    {
        public string CarName;
        public int PriceCar;

        public Car()
        {
            
        }

        public Car(string carName, int priceCar)
        {
            CarName = carName;
            PriceCar = priceCar;
        }

        public virtual void InfoCar()
        {
            Console.WriteLine($"Vinfast: {CarName}");
            Console.WriteLine($"is Price: {PriceCar}");
            
        }

      
    }
}
   


