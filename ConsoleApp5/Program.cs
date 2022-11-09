using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0; i<5; i++)
            //{
            //    for (int k = 0; k < 5 -i; k++) 
            //            Console.Write(" ");
            //   for (int j = 0; j <= i * 2; j++)
            //        Console.Write("*");
            //    Console.Write(" -> {0}. Üçgen satırı\n",(i+1));
            //}

            //Console.ReadLine();

            //DateTime date1 = DateTime.Now;

            //switch (date1.DayOfWeek)
            //{

            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("HaftaSonu");
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("HaftaSonu");
            //        break;

            //    default:
            //        Console.WriteLine("Hafta içi");
            //        break;

            //}

            //Console.ReadLine();
            //for (int i = 1; i < 20; i++)
            //{
            //    for (int j = 1; j < 20; j++)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int k = 1; k <= i; k++)
            //    {

            //        Console.Write("*");
            //        Console.Write(" ");
            //    }   


            //    Console.ReadLine();

            //int a = 100;
            //while (a >= 1)
            //{
            //    Console.WriteLine(a);
            //    a--;


            //}
            //Console.ReadLine();

            //int a = 1;
            //do
            //{ Console.WriteLine(a); a++; 
            //}
            //while (a <= 10);
            //Console.ReadLine();

            //Jump Statements, break, continue

            //for(int a = 1; a < 10; a++)
            //{
            //    if (a == 7)
            //        //break
            //        break;
            //    Console.WriteLine("a nin degeri:" + a);

            //}
            //Console.ReadLine();


            //int not;


            //Console.WriteLine("lutfen bir not giriniz");
            //not = Convert.ToInt32(Console.ReadLine());
            //if(not>50) 
            //{
            //    Console.WriteLine("ogrenci basarilidir");



            //}

            //else
            //{
            //    Console.WriteLine("ogrenci basarisizdir");

            //}
            //     Console.ReadLine();

            //int not1;
            //int not2;


            //Console.WriteLine("lutfen not1 giriniz");
            //not1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lutfen not2 giriniz");
            //not2 = Convert.ToInt32(Console.ReadLine());
            //double ortalama = Convert.ToInt32(not1 * 0.40 + not2 * 0.60);
            //Console.WriteLine("ogrenci ortalaması: " + ortalama);
            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("ogrenci basarilidir");

            //}
            //else
            //{
            //    Console.WriteLine("ogrenci basarisizdir");
            //}



            //Console.ReadLine();

            //string kullaniciadi;
            // string sifre;


            // Console.WriteLine("Lutfen kullanici adi giriniz");
            // kullaniciadi = Console.ReadLine();

            // Console.WriteLine("Lutfen sifrenizi giriniz");
            // sifre = Console.ReadLine();

            // if (kullaniciadi == "omer" && sifre == "1234")

            // {
            //     Console.WriteLine("giris basarili");

            // }
            // else
            // {
            //     Console.WriteLine("giris basarisiz");
            // }
            // Console.ReadLine();


            //int sayi1;

            //Console.WriteLine("sayi1 kup alınız");

            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //int secim;

            //Console.WriteLine("lutfen birle iki arası secim yapiniz");
            //secim= Convert.ToInt32(Console.ReadLine()); 

            //if (secim== 1)
            //{
            //    double kup = Math.Pow(sayi1, 3);
            //    Console.WriteLine(kup);
            //}


            //  else if (secim == 2)
            //{   double kok = Math.Sqrt(sayi1);
            //    Console.WriteLine(kok);}







            //Console.ReadLine();


            //string mevsimler;
            //int kilo;
            //Console.WriteLine("lutfen mevsim yazın");
            //mevsimler= Console.ReadLine();
            //Console.WriteLine("Lutfen kılonuzu yazınız");
            //kilo=Convert.ToInt32(Console.ReadLine());
            //if (mevsimler == "ilkbahar")
            //{
            //    if (kilo >=50 && kilo<=60 )
            //    {

            //        Console.WriteLine("ideal kilo");
            //    }

            // }

            //if (mevsimler == "yaz")


            //{

            //    if (kilo>=70 && kilo <=80)
            //        Console.WriteLine("ideal kilo");

            //}

            //if (mevsimler == "sonbahar")
            //{
            //    if (kilo >= 80 && kilo <= 90)
            //        Console.WriteLine("ideal kilo");
            //}
            //if (mevsimler == "kış")
            //{ 
            //    if (kilo >= 91 && kilo <= 100)
            //        Console.WriteLine("ideal kilo");
            //}


            //Console.ReadLine();

            //int secim;
            //Console.WriteLine("lutfen bir secim yapiniz");
            //secim=Convert.ToInt32(Console.ReadLine());
            //switch(secim)

            //{ 
            //case 1: Console.WriteLine("ilkbahar"); break;
            //case 2: Console.WriteLine("yaz"); break;
            //case 3: Console.WriteLine("sonbahar"); break;
            //case 4: Console.WriteLine("kıs"); break;

            //    default: Console.WriteLine("lutfen 1 ile 4 arası bir secim yapiniz"); break;


            //}

            //Console.ReadLine();

            //string light;
            //Console.WriteLine("lutfen bir renk seciniz (kirmizi , sari , yesil) ");
            //light = Console.ReadLine();
            //switch(light)
            //{
            //    case "kirmizi": Console.WriteLine("dur"); break;
            //    case "sari": Console.WriteLine("hazırlan");break;
            //    case "yesil": Console.WriteLine("gaza bas geç"); goto case "sari";
            //default : Console.WriteLine("kaza yaptın"); break;
            //}
            //Console.ReadLine();

            // for (int i = 1; i <= 100; i++)
            // {
            //     Console.WriteLine(i);
            // }


            //Console.ReadLine();

            //Random rnd = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    int a = rnd.Next(0,100);
            //    Console.WriteLine(a);
            //}

            //Console.ReadLine();

            //Console.Write("Lutfen bir sayi giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int faktoriyel = 1;
            //for (int i = 1; i <= sayi; i++)
            //{

            //    faktoriyel *= i;
            //}
            //Console.WriteLine(sayi + "! = " + faktoriyel);

            //Console.ReadLine();

            //int sayac = 0;
            //Console.WriteLine("bir sayi girin");
            //int sayi=Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < sayi; i++)
            //{ 
            //    if (sayi % i == 0)
            //    {
            //       sayac++;



            //    }
            //}
            //if (sayac != 0)
            //{
            //    Console.WriteLine("Sayı asal degildir.");
            //}
            //    else
            //{
            //    Console.WriteLine("Sayı asaldir");

            //}

            //Console.ReadLine();

           










        }
        }
    }

