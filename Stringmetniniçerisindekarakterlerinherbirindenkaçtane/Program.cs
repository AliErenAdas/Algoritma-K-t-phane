using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringmetniniçerisindekarakterlerinherbirindenkaçtane
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("metin giriniz");
            String metin = Console.ReadLine();
            

            String karakter = "0123456789ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVWXYZabcçdefgğhıijklmnoöpqrsştuüvwxyz.?,;+-/*><|)(/&%+^'!é#${[]} ";
            
            int[] dizi = new int[karakter.Length];
            
            for (int i = 0; i < metin.Length; i++)
            {
                int sayi = karakter.IndexOf(metin[i]);
                if (sayi < 0)
                    continue;
                else
                {
                    dizi[sayi]++;
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakter[i] + " " + dizi[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
