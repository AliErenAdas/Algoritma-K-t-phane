using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucsayiyisiralayanifade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayiyi giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü sayıyı giriniz : ");
            int sayi3 = int.Parse(Console.ReadLine());

            if (sayi1 < sayi2 && sayi1 < sayi3) 
            {

                if (sayi2<sayi3)
                {
                    Console.WriteLine("sayi3 > sayi2 > sayi1");
                }
                else
                {
                    Console.WriteLine("sayi2 > sayi3 > sayi1");
                }

            }
            if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                if (sayi1 < sayi3)
                {
                    Console.WriteLine("sayi3 > sayi1 > sayi2");
                }
                else
                {
                    Console.WriteLine("sayi1 > sayi3 > sayi2");
                }


            }
            if (sayi3 < sayi1 && sayi3 < sayi2)
            {
                if (sayi1 < sayi3)
                {
                    Console.WriteLine("sayi2 > sayi1 > sayi3");
                }
                else
                {
                    Console.WriteLine("sayi1 > sayi2 > sayi3");
                }
            }
            Console.ReadLine();
        }
    }
}
