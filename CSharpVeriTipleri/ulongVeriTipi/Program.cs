using System;

namespace ulongVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 8 byte’tır, 0 ile 2 x 10^20 arasında değer alır.

            ulong maxDeger = ulong.MaxValue;
            ulong minDeger = ulong.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
