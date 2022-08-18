using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManageri
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler, Müşteri eklendi: " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Silme(int Id)
        {
            Console.WriteLine(Id + " numaralı müşteri Başarıyla Silindi");
        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            }
        }
    }
}
