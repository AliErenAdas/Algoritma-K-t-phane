using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fibonacci dizisinde kaçıncı terimi kadar bilgi almak istediğinizi belirtiniz");
            
            int dizi = int.Parse(Console.ReadLine());
            
            int x = 1, y = 1, z;
            
            int sayac = 3;

            Console.WriteLine(x);
            Console.WriteLine(y);

            while (sayac<=dizi)
            {
                z = x + y;
               
                Console.WriteLine(z);
                
                x = y;
                y = z;
                
                sayac = sayac + 1;
            }

            Console.ReadLine();

        }
    }
}
