using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HesapMakinesiMetot
{
    class HesapMakinesi
    {
        static void Main(string[] args)
        {
            
            Tanım();

            string cevap = null;
            double sonuc = 0;
            string[] islemler;
            string[] sayilar;

            do
            {
             string alinanveri = VeriAl();

             Ayirma(alinanveri, out islemler, out sayilar);

             IslemYap(sayilar, islemler, out sonuc);

             Console.WriteLine("Başka bir işlem yapmak istiyorsanız lütfen 1 yazıp Enter tuşuna basınız");
             cevap = Console.ReadLine();


            } while (cevap == "1");


        }
        static public void Tanım()// Yazılan Kodun Tanıtımı
        {
            string msg = "Hesap Makinesi";
            Console.WriteLine(msg);
        }
        
        static public string VeriAl()//Kullanıcıdan Veri Alma işlemi
        {
            
            string alinanveri;
            alinanveri = Console.ReadLine().Trim();


            return alinanveri;
        }
        static public void Ayirma(string alinanveri, out string[] islemler, out string[] sayilar) //Alınan Verideki Karakterleri Ayırma İşemi
        {
            char[] islemayirma = { '=', '+', '-', '/', '*', 'x','X',':' };
            
            sayilar = alinanveri.Split(islemayirma, StringSplitOptions.RemoveEmptyEntries);

            islemler = new string[sayilar.Length - 1];

            int h = 0;

            for (int i = 0; i < alinanveri.Length; i++)
            {
                string sayi1 = alinanveri[i].ToString();

                if (!int.TryParse(sayi1, out int k) && sayi1 != "=")
                {

                    islemler[h] = sayi1;

                    h++;
                }

            }

        }
        private static void DiziKucultme(int i, ref string[] sayilar, ref string[] islemler, double sonuc)
        {
            string[] dizi2 = new string[sayilar.Length - 1];
            int sayac1 = 0;
            int sayac2 = 0;

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayac2 == i)
                {

                }
                else if (sayac2 == i + 1)
                {
                    dizi2[sayac1] = sonuc.ToString();
                    sayac1++;
                }
                else
                {
                    dizi2[sayac1] = sayilar[sayac2];
                    sayac1++;
                }
                sayac2++;
            }

            sayilar = new string[dizi2.Length];

            Array.Copy(dizi2, sayilar, dizi2.Length);



            dizi2 = new string[islemler.Length - 1];

            sayac1 = 0;
            sayac2 = 0;

            for (int j = 0; j < islemler.Length; j++)
            {
                if (sayac2 == i)
                {

                }
                else
                {
                    dizi2[sayac1] = islemler[sayac2];
                    sayac1++;
                }
                sayac2++;
            }

            islemler = new string[dizi2.Length];

            Array.Copy(dizi2, islemler, dizi2.Length);



        } //  islem yapıldıktan sonra dizide oluşan boşluğu diziyi küçülterek ortadan kaldırdıran metot.
        static public void IslemYap(string[] sayilar, string[] islemler, out double sonuc) 
         {
            sonuc = 0;

            for (int i = 0; i < islemler.Length; i++)
            {
                if (islemler[i] == "*"|| islemler[i] =="x"|| islemler[i] =="X")
                {
                    
                    CarpmaIslem(i, ref sayilar, ref islemler, ref sonuc);
                    if (sayilar.Length == 1)
                    {
                        Sonuc(sonuc);
                        break;
                    }
                    i = -1;
                }
                sonuc = 0;
            }

            
            for (int i = 0; i < islemler.Length; i++)
            {
                if (islemler[i] == "/" || islemler[i] ==":")
                {
                    BolmeIslem(i, ref sayilar, ref islemler, ref sonuc);
                    if (sayilar.Length == 1)
                    {
                        Sonuc(sonuc);
                        break;
                    }
                    i = -1;
                }
                sonuc = 0;
            }

            
            for (int i = 0; i < islemler.Length; i++)
            {
                if (islemler[i] == "+")
                {
                    ToplamaIslem(i, ref sayilar, ref islemler, ref sonuc);
                    if (sayilar.Length == 1)
                    {
                        Sonuc(sonuc);
                        break;
                    }
                    i = -1;
                }
                sonuc = 0;
            }

            
            for (int i = 0; i < islemler.Length; i++)
            {
                if (islemler[i] == "-")
                {
                    CikarmaIslem(i, ref sayilar, ref islemler, ref sonuc);
                    if (sayilar.Length == 1)
                    {
                        Sonuc(sonuc);
                        break;
                    }
                    i = -1;
                }
                sonuc = 0;
            }



        }// + - * / işlemlerinin cağırıldığı metot. 
        private static void CarpmaIslem(int i,   ref string[] sayilar, ref string[] islemler, ref double sonuc)
        {
            double sayi1 = Convert.ToDouble(sayilar[i]);

            double sayi2 = Convert.ToDouble(sayilar[i + 1]);

            sonuc += (sayi1 * sayi2);

            DiziKucultme(i,  ref sayilar, ref islemler, sonuc);
        }// diziden alınan sayıların işlemi ve dizi küçültme metodu çağırdığın yer
        private static void BolmeIslem(int i,ref string[] sayilar, ref string[] islemler, ref double sonuc)
        {
            double sayi1 = Convert.ToDouble(sayilar[i]);

            double sayi2 = Convert.ToDouble(sayilar[i + 1]);

            sonuc += (sayi1 / sayi2);

            DiziKucultme(i,  ref sayilar, ref islemler, sonuc);
        }
        private static void CikarmaIslem(int i,  ref string[] sayilar, ref string[] islemler, ref double sonuc)
        {
            double sayi1 = Convert.ToDouble(sayilar[i]);

            double sayi2 = Convert.ToDouble(sayilar[i + 1]);

            sonuc += (sayi1 - sayi2);

            DiziKucultme(i,  ref sayilar, ref islemler, sonuc);
        }
        private static void ToplamaIslem(int i,   ref string[] sayilar, ref string[] islemler, ref double sonuc)
        {
            double sayi1 = Convert.ToDouble(sayilar[i]);

            double sayi2 = Convert.ToDouble(sayilar[i + 1]);

            sonuc += (sayi1 + sayi2);

            DiziKucultme(i,  ref sayilar, ref islemler, sonuc);
        }
        
        static public void Sonuc(double sonuc)
        {
            Console.WriteLine($"Sonuç = {sonuc}");

        }






    }
}
