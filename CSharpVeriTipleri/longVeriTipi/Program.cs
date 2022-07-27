using System;

namespace longVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 8 byte’tır, -10^20 ile 10^20 arasında değer alır.

            long maxDeger = long.MaxValue;
            long minDeger = long.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
