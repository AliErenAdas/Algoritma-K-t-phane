using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezarsifrelemesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin giriniz");
            string metin = Console.ReadLine();

            char[] deger = new Char[metin.Length];

            deger = metin.ToCharArray();

            int sayi = 0;

            for (int i = 0; i < deger.Length; i++)
            {
                sayi = Convert.ToInt32(deger[i]);
                

                if (sayi>=97 && sayi<=122)
                {
                    sayi = sayi + 3;
                    if (sayi>122)
                    {
                        sayi -=26;
                    }
                    

                    deger[i] = Convert.ToChar(sayi);
                }
                if (sayi >= 65 && sayi <= 90)
                {
                    sayi = sayi + 3;
                    if (sayi > 90)
                    {
                        sayi -= 26;
                    }


                    deger[i] = Convert.ToChar(sayi);
                }

            }

            foreach (var item in deger)
            {
                Console.Write(item);
            }

            Console.ReadLine();

        }
    }
}
