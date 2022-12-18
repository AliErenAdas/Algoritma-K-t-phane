using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayarınrastgeletuttugu10sayinincifttekincelemesi
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new Random();


            int cift = 0, tek = 0;

            int[,] dizi = new int[10,5];

            for (int i = 0; i < 10; i++)
            {
                

                for (int j = 0; j < 5; j++)
                {
                    dizi[i, j] = rastgele.Next(1, 101);

                    Console.Write(dizi[i,j]+"      ");
                    if (dizi[i, j] % 2 == 0)
                    {
                        cift++;
                    }
                    else
                        tek++;
                }

                Console.WriteLine();
                
            }
            Console.WriteLine($"Çift sayı={cift}\nTek sayı={tek} ");
            

            Console.ReadKey();

        }
    }
}
