using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KriptoDekripto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine("Şifreleme Sisteminiz Hazır");
            Console.WriteLine("Sistem Başlatılsın mı?");
            string cevap = Console.ReadLine().Trim().ToLower();

            if (cevap == "evet")
            {
                Console.WriteLine("Kriptolama Başlatılıyor...");
                kripto();
            }
            else
            {
                Main(args);
            }

            Console.ReadLine();
        }
        static void kripto()
        {
            #region

            Console.WriteLine("Metin giriniz");
            string metin = Console.ReadLine();
            char[] deger = new Char[metin.Length];

            deger = metin.ToCharArray();

            int sayi = 0;

            for (int i = 0; i < deger.Length; i++)
            {
                sayi = Convert.ToInt32(deger[i]);
                sayi = (sayi * 2) - 3;
                deger[i] = Convert.ToChar(sayi);


            }
            Console.WriteLine("Şifreleme işlemi başarı ile tamamlandı.");

            foreach (var item in deger)
            {
                Console.Write(item);
            }

            Console.WriteLine("Şifre Çözme İşlemi Başlatılsın Mı?");
            string cevap = Console.ReadLine().Trim().ToLower();

            if (cevap == "evet")
            {
                for (int i = 0; i < deger.Length; i++)
                {
                    sayi = Convert.ToInt32(deger[i]);
                    sayi = (sayi + 3) / 2;
                    deger[i] = Convert.ToChar(sayi);
                }
                Console.WriteLine("Şifre Çözme işlemi başarı ile tamamlandı.");
                Console.Write("Şifreniz      :     ");

                foreach (var item in deger)
                {
                    Console.Write(item);
                }
            }
            else
            {
                Console.WriteLine("İyi Günler Dileriz");
            }

            #endregion
        }
    }
}
