using System;

namespace byteVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.

            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
