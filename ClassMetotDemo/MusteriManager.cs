using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele (Musteri musteri)
        {
            Console.WriteLine("----Müşteri bilgileri----");
            Console.WriteLine("                         ");
            Console.WriteLine("Müşteri Id : "+musteri.Id);
            Console.WriteLine("Müşteri Adı : "+musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri Telefon Numarası : " + musteri.TelefonNumarası);
            Console.WriteLine("Müşteri Yaşı : " + musteri.Yas);
            Console.WriteLine("Müşteri Anne Kızlık Soyadının Sondan 2. Harfi : " + musteri.AnneKizlikSoyadi[1]);
            Console.WriteLine("Müşteri Mesleği : " + musteri.Meslek);
            Console.WriteLine("Müşteri Mal Varlığı : " + musteri.MalVarligi);
            Console.WriteLine("------------------------");
        }
        public void Ekle(Musteri museteri)
        {

        }
    }
}
