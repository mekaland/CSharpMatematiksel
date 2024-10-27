using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Matematiksel İşlemler 

            Matematik m = new Matematik();
            YenidenIslemYap:
            m.menuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.WriteLine("lütfen bir sayi değeri giriniz ");
            int kullaniciSayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("lütfen bir sayi değerini giriniz ");
            int kullaniciSayi2 = int.Parse(Console.ReadLine());

            decimal sonuc = 0 ;

            switch (kullaniciSecim)
            {
                case 1: //toplama
                    sonuc = m.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    m.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;

                case 2: //çıkarma
                    sonuc = m.cıkarmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    m.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = m.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    m.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                case 4:
                    sonuc = m.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    m.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                default:
                    Console.WriteLine("girmiş olduğunuz  değer liste içerisinde bulunamadı");
                    Console.WriteLine("lütfen yeniden deneyiniz");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;

                    
            }
            Console.ReadLine() ;
            #endregion 
        }

    }
}
