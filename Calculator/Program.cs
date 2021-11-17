using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1, sayi2;
            bool sayiDonustumu1 = false;
            bool sayiDonustumu2 = false;
            double sonuc=0;
            string islem;
            double donusenSayi1 = 0;
              double   donusenSayi2 = 0;
            Console.WriteLine("Birinci sayiyi girin");
            sayi1 = Console.ReadLine();
            sayiDonustumu1 = double.TryParse(sayi1, out donusenSayi1);
            if (sayiDonustumu1==false)
            {
                do
                {
                    Console.WriteLine("Lutfen Bir sayi giriniz");
                    sayi1 = Console.ReadLine();
                    sayiDonustumu1 = double.TryParse(sayi1, out donusenSayi1);
                } while (sayiDonustumu1 == false);
               
            }
         
            Console.WriteLine("İkinci sayi girin");
            
            sayi2 =Console.ReadLine();
            sayiDonustumu2 = double.TryParse(sayi2, out donusenSayi2);

            if (sayiDonustumu2 == false)
            {
                do
                {
                    Console.WriteLine("Lutfen Bir sayi giriniz");
                    sayi2 = Console.ReadLine();
                    sayiDonustumu2 = double.TryParse(sayi2, out donusenSayi2);
                } while (sayiDonustumu2 == false);

            }


            Console.WriteLine("Bir işlem seçiniz(carpma,toplama,bolme,cikarma)");
            islem = Console.ReadLine();
            
            if (islem == "carpma")
            {
                sonuc = donusenSayi1 * donusenSayi2;
                Console.WriteLine("işleminizin sonucu (yukarıya yuvarlanmış hali): {0}", Math.Ceiling(sonuc));
            }
           else if (islem == "bolme")
            {
                sonuc = donusenSayi1 / donusenSayi2;
                Console.WriteLine("işleminizin sonucu (yukarıya yuvarlanmış hali): {0}", Math.Ceiling(sonuc));
            }
            else if (islem == "toplama")
            {
                sonuc = donusenSayi1 + donusenSayi2;
                Console.WriteLine("işleminizin sonucunuz (yukarıya yuvarlanmış hali): {0}", Math.Ceiling(sonuc));
            }
            else if (islem == "cikarma")
            {
                sonuc = donusenSayi1 - donusenSayi2;
                Console.WriteLine("işleminizin sonucu (yukarıya yuvarlanmış hali): {0}", Math.Ceiling(sonuc));
            }
            else
            {
                Console.WriteLine("yanlış bir işlem seçtiniz");
            }
            /*
             Yanlış bir işlem yapıldığında en son "işleminizin
             sonucu 0" yazmasın diye sonucu if içerisinde
             yazdırıyorum.
             */
        }
    }
}
