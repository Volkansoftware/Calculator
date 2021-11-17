using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;
            
           double sonuc=0;
            string islem;
           
            Console.WriteLine("Bir sayi girin");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Bir sayi girin");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bir işlem seçiniz(carpma,toplama,bolme,cikarma)");
            islem = Console.ReadLine();
            if (islem == "carpma")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("işleminizin sonucu (yukarıya yuvarlanmış hali): {0}", Math.Ceiling(sonuc));
            }
           else if (islem == "bolme")
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("işleminizin sonucu (yukarıya yuvarlanmış hali): {0}", Math.Ceiling(sonuc));
            }
            else if (islem == "toplama")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("işleminizin sonucunuz (yukarıya yuvarlanmış hali): {0}", Math.Ceiling(sonuc));
            }
            else if (islem == "cikarma")
            {
                sonuc = sayi1 - sayi2;
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
