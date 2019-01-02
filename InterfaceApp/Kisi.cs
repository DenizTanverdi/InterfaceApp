using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Kisi : IKimlik
    {
        public cinsiyet Cinsiyet { get { return Cinsiyet; } set { Cinsiyet = value; } }
        public din Din { get { return Din; } set { Din = value; } }
        public string TcKimlikNo { get { return TcKimlikNo; } set { TcKimlikNo = value; } }
        public string DogumYeri { get { return DogumYeri; } set { DogumYeri = value; } }
        public string DogumTarihi { get { return DogumTarihi; } set { DogumTarihi = value; } }
        public string Ad { get { return Ad; } set { Ad = value; } }
        public string Soyad { get { return Soyad; } set { Soyad = value; } }
        public string BabaAdi { get { return BabaAdi; } set { BabaAdi = value; } }

        public string FullName()
        {
            throw new NotImplementedException();
        }
    }
}
