using System;

namespace intVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.

            int maxDeger = int.MaxValue;
            int minDeger = int.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
