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



    }
}
