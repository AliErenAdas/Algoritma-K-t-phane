using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler5sayiortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 adet değer giriniz");

            int[] sayi = new int[5];
            int toplam = 0;
            double ort;

            for (int i = 0; i < sayi.Length; i++)
            {

                Console.Write(i+1 + ".Sayi giriniz : ");

                sayi[i] = Convert.ToInt32(Console.ReadLine());

                toplam = toplam + sayi[i];

            }
            ort = toplam / sayi.Length;

            foreach (var item in sayi)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("ortalama sonucu : " + ort);

            Console.ReadKey();
            
            


        }
    }
}
