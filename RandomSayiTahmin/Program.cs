using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random olarak girilen sayıyı tahmin etmeye çalışın");

            
            Random random = new Random();
            int number = random.Next(1, 101);

            int cevap, sayac = 0;

            do
            {
                
                cevap = int.Parse(Console.ReadLine());

                if (cevap > number) 
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                }
                else 
                {
                    Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                }

                sayac = sayac + 1;


            } while (cevap!= number);

            Console.WriteLine("Tebrikler Doğru Bildiniz");

            Console.WriteLine(sayac + "   Deneme Yaptınız.Daha İyisini Yapabilirsiniz");

            Console.ReadLine();





        }
    }
}
