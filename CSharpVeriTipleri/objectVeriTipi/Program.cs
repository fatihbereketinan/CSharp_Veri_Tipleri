using System;

namespace objectVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* object tipi değişken tanımlarsanız eğer asıl veri tipi belleğe kaydedilmez object olarak
             kaydedilir. Veriyi kullanmak istediğimizde asıl veri tipini elde ederek kullanmalıyız. */

            object sayi = 10; //Boxing: Object olarak kaydedildi.
            object isim = "Fatih";
            object karekter = 'F';
            object ondalikli = 10.5F;

            Console.WriteLine(sayi);
            Console.WriteLine(isim);
            Console.WriteLine(karekter);
            Console.WriteLine(ondalikli);

            int sayiKullan = Convert.ToInt32(sayi); //Unboxing: Asıl veri tipine çeviriyoruz.
           
        }
    }
}
