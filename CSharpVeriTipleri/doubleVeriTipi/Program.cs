using System;

namespace doubleVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 8 byte’tır, -1.7 x 10^308 ile 1.7 x 10^308 arasında değer alır.
            //Ondalık sayı türünde elemanlar alan veri tipidir.

            double maxDeger = double.MaxValue;
            double minDeger = double.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
