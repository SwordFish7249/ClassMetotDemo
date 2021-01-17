using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public static class MusteriManager
    {
        
        public static void Add(params Musteri[] musteriler)
        {
            
             Musteri[] musteriList = new Musteri[] { };
            for(int i = 0; i<musteriList.Length; i++)
            {
                
                Console.WriteLine(musteriList[i]);
            }
           
        }

        public static void List(params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriId + " " + musteri.musteriKimlik + " " + musteri.musteriYas + musteri.musteriPara);
            }
        }

        public static void Delete(params Musteri[] musteriler)
        {
            int i = 3;
            int del;
            Musteri[] musteriList = new Musteri[] { };
            for(del = i - 1; del<musteriList.Length; del++)
            {
                musteriList[del] = musteriList[del + 1];
            }
            Console.WriteLine("Musteri silindikten sonra liste");
        }
    }
}
