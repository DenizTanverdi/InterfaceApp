using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Program
    {
       static Personel p;
       static  Departman d;
        static void Main(string[] args)
        {
            p = new Personel();
            p.Ad = "deniz";
            p.Soyad = "Tanrıverdi";
            p.TcKimlikNo = "386956546";
            p.CepTelefonu = "5468736162";
            p.DogumTarihi = new DateTime(1995, 10, 10);
            p.DogumYeri = "Aravutköy";
            p.Cinsiyet = cinsiyet.Erkek;
            p.Din = din.Para;
            d = new Departman();
            d.Butce = 10000;
            d.DepartmanAd = departman.IK;
            DataEkle();
        }

        public static void DataEkle()
        {
            foreach (Personel item in p)
            {
                Console.WriteLine(item.Ad);


            }
            
            Console.ReadLine();
            
        }
    }

  
}
