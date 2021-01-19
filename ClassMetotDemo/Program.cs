using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 001;
            musteri1.Ad = "Göktuğ";
            musteri1.Soyad = "Karakuş";
            musteri1.TelefonNumarası = 999999999;
            musteri1.Yas = 20;
            musteri1.AnneKizlikSoyadi = "Kuzu";
            musteri1.Meslek = "Kimyager";
            musteri1.MalVarligi = 999999999;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 002;
            musteri2.Ad = "Hasan";
            musteri2.Soyad = "Günay";
            musteri2.TelefonNumarası = 999999998;
            musteri2.Yas = 19;
            musteri2.AnneKizlikSoyadi = "Çaybaşı";
            musteri2.Meslek = "Ürolog";
            musteri2.MalVarligi = 0;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 003;
            musteri3.Ad = "Metehan";
            musteri3.Soyad = "Özcan";
            musteri3.TelefonNumarası = 999999997;
            musteri3.Yas = 19;
            musteri3.AnneKizlikSoyadi = "Argüz";
            musteri3.Meslek = "Veteriner";
            musteri3.MalVarligi = 350;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 004;
            musteri4.Ad = "Batuhan";
            musteri4.Soyad = "Bilgi";
            musteri4.TelefonNumarası = 999999996;
            musteri4.Yas = 31;
            musteri4.AnneKizlikSoyadi = "Budak";
            musteri4.Meslek = "Gemi Kaptanı";
            musteri4.MalVarligi = 6900000;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);


        }
    }
}
