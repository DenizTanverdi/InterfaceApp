using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Kisi : IKimlik
    {
        private string ad;
        private string soyad;
        string babaAdi;
        string tcKimlik;
        DateTime dogumTarihi;
        string dogumYeri;
        cinsiyet cinsiyet;
        din din;
        
        public cinsiyet Cinsiyet { get { return cinsiyet; } set { cinsiyet = value; } }
        public din Din { get { return din; } set { din = value; } }
        public string TcKimlikNo { get { return tcKimlik; } set { tcKimlik = value; } }
        public String DogumYeri { get { return dogumYeri; } set { dogumYeri = value; } }
        public DateTime DogumTarihi { get { return dogumTarihi; } set { dogumTarihi = value; } }
        public string Ad { get { return ad; } set { ad = value; } }
        public string Soyad { get { return soyad; } set { soyad = value; } }
        public string BabaAdi { get { return babaAdi; } set { babaAdi = value; } }
        private string cepTelefonu;

        public string CepTelefonu
        {
            get { return cepTelefonu; }
            set { cepTelefonu = value; }
        }

        string IKimlik.DogumYeri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FullName()
        {
            return Ad + " " + Soyad;
        }
    }
    
}
