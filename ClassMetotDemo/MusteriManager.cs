using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) {

            Console.WriteLine(musteri.ad +"Müşteri Listesine Eklendi.");
        
        
        }

        public void Listele(Musteri[] musteriDizisi) {

            foreach (var item in musteriDizisi)
            {
                Console.WriteLine("Müşteri Id : "+item.id);
                Console.WriteLine("Müşteri Ad : "+item.ad);
                Console.WriteLine("Müşteri Soyad : "+item.soyad);
                Console.WriteLine("Müşteri Telefon : "+item.telefon);
                Console.WriteLine("*********************");

            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.id+" : id'li müşteri silindi.");

        }


    }
}
