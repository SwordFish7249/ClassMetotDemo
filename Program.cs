using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        { 

            
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "CEM";
            musteri1.musteriSoyadi = "GÖKDEL";
            musteri1.musteriId = 1;
            musteri1.musteriKimlik = "241593";
            musteri1.musteriYas = 29;
            musteri1.musteriPara = 50000;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "EBRU";
            musteri2.musteriSoyadi = "SENA";
            musteri2.musteriId = 2;
            musteri2.musteriKimlik = "15515085";
            musteri2.musteriYas = 25;
            musteri2.musteriPara = 250000;

            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "ENGİN";
            musteri3.musteriSoyadi = "DEMİROĞ";
            musteri3.musteriId = 3;
            musteri3.musteriKimlik = "156555555";
            musteri3.musteriYas = 30;
            musteri3.musteriPara = 800000;

            Musteri musteri4 = new Musteri();
            musteri4.musteriAdi = "BERKAY";
            musteri4.musteriSoyadi = "BİLGİN";
            musteri4.musteriId = 4;
            musteri4.musteriKimlik = "156555560";
            musteri4.musteriYas = 29;
            musteri4.musteriPara = 600000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager.List(musteriler);
            MusteriManager.Delete(musteri4);
            MusteriManager.List(musteriler);
            MusteriManager.Add(musteri1);
            MusteriManager.List(musteriler);
        }
    }
    
   
}
