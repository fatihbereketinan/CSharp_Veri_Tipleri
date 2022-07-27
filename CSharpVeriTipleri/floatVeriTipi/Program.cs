using System;

namespace floatVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzunluğu 4 byte’tır, -3.4 x 10^38 ile 3.4 x 1038 arasında değer alır. //Ondalık sayı türünde elemanlar alan veri tipidir.
            //Değişken ataması yapılırken girilen değerin sonuna F yazılır. Örn: float os = 10.5F;

            float maxDeger = float.MaxValue;
            float minDeger = float.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
