using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;

            dizi = new int[5];

            //Dizilere Değer Atama Ve Erişim

            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);

            // Döngülerde Dizi
            // Klavyeden girilen n tane sayının ortalamasını alan yazılım.

            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz.", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;

            foreach (var sayi in sayiDizisi)

                toplam += sayi;
           
            Console.WriteLine("Ortalama :" + toplam / diziUzunlugu);











        }

    }

}