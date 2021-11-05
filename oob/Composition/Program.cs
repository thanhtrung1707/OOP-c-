using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMigrator DataMig = new DataMigrator();

            DataMig.Migrate();

            Console.ReadLine();        }
    }
}