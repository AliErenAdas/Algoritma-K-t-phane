using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20elemanlidiziyerastgele_100ile_100sayılararasıdizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];

            Random rastgele = new Random();

            int pozitif=0, negatif=0, sıfır= 0;
            
            for (int i = 0; i < 20; i++)
            {
                dizi[i] =rastgele.Next(-101, 101);
                
                if (dizi[i] ==0)
                {
                    sıfır++;
                }
                if (dizi[i]>0)
                {
                    pozitif++;
                }
                if (dizi[i]<0)
                {
                    negatif++;
                }
               
                Console.WriteLine(dizi[i]);


            }

            

            Console.WriteLine($"Pozitif sayı adedi {pozitif}");

            Console.WriteLine($"Dizideki sıfır sayı adedi {sıfır}");

            Console.WriteLine($"Negatif sayı adedi {negatif}");

            Console.ReadKey();


        }
    }
}
