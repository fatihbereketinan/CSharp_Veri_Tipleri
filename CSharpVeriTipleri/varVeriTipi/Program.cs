using System;

namespace varVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Var tip değişken tanımlarsanız eğer değişkenin tipini biz değil derleyici tanımlayacaktır.
             Derleyicinin tanımladığı tipe göre o veri RAM üzerinde o tipte saklanacaktır. */

            var sayi = 10;
            var isim = "Fatih";
            var karekter = 'F';
            var ondalikli = 10.5F;

            Console.WriteLine(sayi);
            Console.WriteLine(isim);
            Console.WriteLine(karekter);
            Console.WriteLine(ondalikli);

        }
    }
}
