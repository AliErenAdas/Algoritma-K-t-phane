using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesli_ve_Sessiz_harflerin_sayısını_bulan_kod
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            char[] sesliharf = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int sayac = 0, sayac2 = 0;
            char[] sessizharf = { 'b', 'c', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };

            Console.WriteLine("Bir metin giriniz : ");
            metin = Console.ReadLine();

            for (int i = 0; i < sesliharf.Length; i++)
            {
                for (int j = 0; j < metin.Length; j++)
                {
                    if (metin[j] == sesliharf[i])
                    {

                        sayac++;
                    }
                }
            }
            for (int k = 0; k < sessizharf.Length; k++)
            {
                for (int l = 0; l < metin.Length; l++)
                {
                    if (metin[l] == sessizharf[k])
                    {
                        sayac2++;
                    }
                }
            }
            Console.WriteLine($"Girdiğiniz metin içerisinde {sayac} tane sesli harf, {sayac2} tane sessiz harf bulunmaktadır. ");
            Console.ReadLine();
        }
    }
}
