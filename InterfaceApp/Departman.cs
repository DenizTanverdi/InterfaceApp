using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Departman
    {
        private departman departmanAd;

        public departman DepartmanAd
        {
            get { return departmanAd; }
            set { departmanAd = value; }
        }
        private int butce;

        public int Butce
        {
            get { return butce; }
            set { butce = value; }
        }
        ArrayList personeller = new ArrayList();

        public int personelEkle(Personel p)
        {

            personeller.Add(p);

            return 1;
        }
        
        public Personel personelGetir(string tcKimlikNo)
        {
            Personel bulunan=new Personel();
            foreach (Personel p in personeller)
            {
                if (p.TcKimlikNo == tcKimlikNo)
                {
                    bulunan = p;
                    break;
                }
                  
            }
            return bulunan;

        }

        public void PersonellerListele()
        {
            Console.WriteLine("Personellerin Listesi ");
            Console.WriteLine("-----------------------");
            foreach (Personel p in personeller)
            {
                Console.WriteLine($"Tc          : {p.TcKimlikNo} ");
                Console.WriteLine($"Ad          : {p.Ad} ");
                Console.WriteLine($"Soyad       : {p.Soyad} ");
                Console.WriteLine($"Baba Adı    : {p.BabaAdi} ");
                Console.WriteLine($"Cep Tel     : {p.CepTelefonu} ");
                Console.WriteLine($"Doğum Tarihi: {p.DogumTarihi} ");
                Console.WriteLine($"Doğum Yeri  : {p.DogumYeri} ");
                Console.WriteLine($"Cinsiyet    : {p.Cinsiyet} ");
                Console.WriteLine($"Din         : {p.Din} ");
                Console.WriteLine($"Email       : {p.Email} ");
                Console.WriteLine("---------------------------");
            }

        }

        public override string ToString()
        {
            return $"Departman Adi {DepartmanAd} \n Bütcesi : {Butce} \n Personel Sayisi : {personeller.Count}";
        }
       
        public ArrayList CinsiyetGetir(cinsiyet c){
            ArrayList per= new ArrayList();
            foreach (Personel p in personeller)
            {
                if (p.Cinsiyet == c)
                {
                    per.Add(p);
                }
            }
            return per;



        }
    }
}
