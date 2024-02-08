using System;
using System.Collections.Generic;
using System.Collections;


namespace Workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            #region Öğrenilenler
            Personel person1 = new Personel(); //Instance

            SelamVer("Enis");
            SelamVer("Engin");
            SelamVer();

            int sonuc = Topla(3, 5);
            Console.WriteLine('\n');

            // Diziler
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Enis";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Sadi";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            Console.WriteLine('\n');

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Niğde" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            Console.WriteLine('\n');

            int sayi1 = 5;
            int sayi2 = 10;
            sayi2 = sayi1;
            sayi1 = 3;
            Console.WriteLine(sayi2);

            // Diziler, Sınıflar, Abstract ve Interface'ler refereans tiptir.
            Console.WriteLine('\n');

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine('\n');

            List<string> yeniSehirler = new List<string>() { "AnkaraG", "İstanbulG", "İzmmirG" };
            yeniSehirler.Add("Niğde");
            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }

            // Mini ödev
            ArrayList myList = new ArrayList(); // Her veri türünden veri atılabilir. Aldığı veriler object olduğu için...
            #endregion


            Console.ReadLine();
        }
        static void SelamVer(string name = "noName") 
        { // Bir değer dönmeyen metot tipi
          // Metotlar parametre sahibi olabilir.
            Console.WriteLine("hey " + name);
        }
        static int Topla(int sayi1, int sayi2 = 10) // default parametreler sona yazılır
        { // Bir değer dönen metot tipi
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
        private static void Degiskenler()
        {
            // Değişkenler verileri bellekte tutmamızı sağlar ve veri tipleri de verinin türünü belirler. 
            string mesage = "hey";
            double value = 100000;
            int number = 100;
            bool isLogin = true;

            string name = "Enis";
            string surname = "Güçlüer";
            int birthYear = 2004;
            long tcNo = 12345678909;
            // Bunlar bir insanın sahip olduğu genel özellikler olmalı. Bunlar bir sınıf içinde bir arada bir insan nesnesi için önceden tanımlanır.
        }
        
    }
    public class Personel
    {
        public string Name { get; set; }
        public string Surname { get; set;}
        public int BirthYear { get; set;}
        public long TcNo { get; set; }
    }
}
