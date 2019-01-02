using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    interface IKimlik
    {
        //SADECE imza bırakılır.
        cinsiyet Cinsiyet { get; set; }
        din Din { get; set; }
        String TcKimlikNo { get; set; }
        string DogumYeri { get; set; }
        DateTime DogumTarihi { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        string BabaAdi { get; set; }
        string FullName();
    }

    enum cinsiyet
    {
        Bayan = 1,
        Erkek = 2,
        Bos = 3
    }
    enum din
    {
        Musluman = 1,
        Hristiyan = 2,
        Musevi = 3,
        Para = 4,
        Bos = 5
    }
}
