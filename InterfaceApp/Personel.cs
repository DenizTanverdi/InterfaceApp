using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Personel:Kisi
    {
        private int maas;

        public int Maas
        {
            get { return maas; }
            set { maas = value; }
        }
        private departman bolum;

        public departman Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }

        private DateTime iseGiris;

        public DateTime IseGiris
        {
            get { return iseGiris; }
            set { iseGiris = value; }
        }

        private calismaSekli calismaSekli;

        public calismaSekli CalismaSekli
        {
            get { return calismaSekli; }
            set { calismaSekli = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string cepTelefonu;

        public string CepTelefonu
        {
            get { return cepTelefonu; }
            set { cepTelefonu = value; }
        }



    }
    enum departman{
        Hizmetli=1,
        Satis=2,
        Muhasabe=3,
        IK = 4,
        IT = 5,
        Yonetim = 6



    }
    enum calismaSekli
    {
        Sozlesmeli=1,
        Kadrolu=2
    }
    
}
