using System;
using System.Collections;
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
            ArrayList dep = new ArrayList();
            DataEkle();
            //d.PersonellerListele();
            //Console.WriteLine( d.ToString());
            dep=d.CinsiyetGetir(cinsiyet.Erkek);
            dep.PersonellerListele();
            Console.ReadLine();
        }

        public static void DataEkle()
        {
            p = new Personel();
            p.Ad = "deniz";
            p.Soyad = "Tanrıverdi";
            p.BabaAdi = "fsd";
            p.TcKimlikNo = "386956546";
            p.CepTelefonu = "54685556162";
            p.DogumTarihi = new DateTime(1995, 10, 10);
            p.DogumYeri = "Aravutköy";
            p.Cinsiyet = cinsiyet.Erkek;
            p.Din = din.Para;
            p.Email = "523123132@sdgfdgfdg.com";
            
            d = new Departman();
            d.Butce = 10000;
            d.DepartmanAd = departman.IK;
            d.personelEkle(p);

            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.CepTelefonu = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Bayan;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "46313654363";
 
            d.Butce = 15000;
            d.DepartmanAd = departman.IT;
            d.personelEkle(p);

            p = new Personel();
            p.TcKimlikNo = "786431313416";
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.CepTelefonu = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Erkek;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
           // p.TcKimlikNo = "46461315646";
            
            d.Butce = 15000;
            d.DepartmanAd = departman.IT;
            d.personelEkle(p);

            p = new Personel();
            p.TcKimlikNo = "46410145615";
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.CepTelefonu = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Bayan;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();

           
            d.personelEkle(p);


        }
    }

  
}
