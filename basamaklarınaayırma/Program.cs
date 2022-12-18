using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basamaklarınaayırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanım();

            int sayi= 0;
             sayi = SayıAl(ref sayi);

            int sayac = 0;

            while (Sayi(sayi))
            {                  
                Islem(ref sayac, ref sayi);
            }
            Console.ReadKey();
        }
        static public void Tanım()
        {
            Console.WriteLine("Belirttiğiniz sayıyı basamaklarına ayırıp ekranda gösteren algoritme");
        }
        static public int SayıAl(ref int sayi)
        {
            Console.Write("Lütfen basamaklarına ayırmak için bir sayı giriniz : ");
            sayi = int.Parse(Console.ReadLine());

            return sayi;
        }
        static public bool Sayi(int sayi)
        {
            if (sayi<0)
            {
                sayi = sayi * (-1);  
            }
            bool sonuc1 = sayi > 0;
            return sonuc1;
        }
        static public void Islem(ref int sayac,  ref int sayi)
        {
            double basamakdegeri = Math.Pow(10, sayac);
            Console.WriteLine((sayi % 10) * basamakdegeri);
            sayi = sayi / 10;
            sayac++;
        }

    }
}
