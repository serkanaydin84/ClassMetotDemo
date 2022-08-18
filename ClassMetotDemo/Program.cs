using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Serkan";
            musteri1.Soyadi = "Aydın";
            musteri1.Yas = 38;
            musteri1.TelNo = "505050505";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Sümeyye";
            musteri2.Soyadi = "Aydın";
            musteri2.Yas = 37;
            musteri2.TelNo = "505050505";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManageri musteriManageri = new MusteriManageri();
            musteriManageri.Ekle(musteri1);

            musteriManageri.Silme(musteri1.Id);

            musteriManageri.Listeleme(musteriler);
        }
    }
}
