using System;

namespace decimalVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzunluğu 12 byte’tır, -7.9 x 10^28 ile +7.9 x 10^28 arasında değer alır.
            // Tam sayı veya ondalıklı sayı tanımlanabilir.
            // Ondalıklı sayı tanımlarken sayının sonuna M harfi koymalıyız. Örn: decimal sayi1 = 12.34M;

            decimal maxDeger = decimal.MaxValue;
            decimal minDeger = decimal.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
        }
    }
}
