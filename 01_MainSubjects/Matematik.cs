using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Matematik
    {
        public decimal toplamaIslemi(int sayi1,int sayi2)
        {
            int sonuc;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public decimal cıkarmaIslemi(int sayi1, int sayi2)
        {
            int sonuc;
            sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public decimal carpmaIslemi(int sayi1, int sayi2)
        {
            int sonuc;
            sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public decimal bolmeIslemi(int sayi1, int sayi2)
        {
            int sonuc;
            sonuc = sayi1 / sayi2;
            return sonuc;
        }
        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("********Menü ******");
            Console.WriteLine("1-Toplama ");
            Console.WriteLine("2-Cıkarma ");
            Console.WriteLine("3-Çarpma ");
            Console.WriteLine("4-Bölme ");

        }

        public void SonucEkranaYaz (decimal kullaniciSayi1 ,  decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3} ", kullaniciSayi1 , operators , kullaniciSayi2, sonuc);
        }
    }
}
