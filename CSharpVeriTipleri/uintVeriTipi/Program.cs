using System;

namespace uintVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.

            uint maxDeger = uint.MaxValue;
            uint minDeger = uint.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
