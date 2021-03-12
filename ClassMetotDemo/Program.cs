using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.ad = "Ahmet";
            musteri1.soyad = "Bozkurt";
            musteri1.telefon = "05050452304";


            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.ad = "Nazım";
            musteri2.soyad = "Bozkurt";
            musteri2.telefon = "05070902304";

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.ad = "Berkay";
            musteri3.soyad = "Bozkurt";
            musteri3.telefon = "05050467314";


            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager metot = new MusteriManager();



            metot.Listele(musteriler);
            metot.Sil(musteri1);
        }
    }
}
