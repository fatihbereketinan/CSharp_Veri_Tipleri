using System;

namespace ushortVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.

            ushort maxDeger = ushort.MaxValue;
            ushort minDeger = ushort.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
