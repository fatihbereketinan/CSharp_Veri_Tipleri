using System;

namespace sbyteVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır.

            sbyte maxDeger = sbyte.MaxValue;
            sbyte minDeger = sbyte.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
