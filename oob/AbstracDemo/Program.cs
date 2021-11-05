using System;

namespace AbstracDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsManager cm = new ClsManager();
            cm.GetEmpData();
            cm.DisplayEmpData();
            Console.ReadKey();
        }
    }
}