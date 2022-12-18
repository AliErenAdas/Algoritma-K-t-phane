using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PersonelinBilgisiniDiziyeKaydetme
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mail = { "ali@ali.com", "mehmet@mehmet.com", "ayse@ayse.com", "fatma@fatma.com", "yılmaz@yılmaz.com", "okan@okan.com","hasan@hasan.com","meryem@meryem.com","dursun@dursun.com","mert@mert.com" };
            string[] isim = { "ali","mehmet","ayse","fatma","yılmaz","okan","hasan","meryem","dursun","mert"};
            string[] telefon = { "135135","12315","8879546","1845646","32156","53165651","6548989","1651651","75613","8798795" };

            Console.WriteLine("Bilgisini almak istediğiniz personelin nosunu giriniz");

            int no = int.Parse(Console.ReadLine());
            if (no>10 || no<0)
            {
                Console.WriteLine("10 personelimiz var. Lütfen 1den 10a kadar olan parsonel numaralarından birini giriniz");
            }
            else
            {
                Console.WriteLine(mail[no - 1]);
                Console.WriteLine(isim[no - 1]);
                Console.WriteLine(telefon[no - 1]);
            }
            

            

            Console.ReadLine();



        }
    }
}
