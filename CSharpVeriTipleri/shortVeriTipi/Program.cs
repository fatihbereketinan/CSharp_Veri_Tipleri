using System;

namespace shortVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.

            short maxDeger = short.MaxValue;
            short minDeger = short.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
