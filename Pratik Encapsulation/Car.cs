using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Encapsulation
{
    public class Car
    {
        //Fieldlar private tanımlandı
        private string _marka;
        private string _model;
        private string _renk;
        private int _kapiSayisi;
        //public property'lerle fieldlere erişim sağlanıyor
        public string Marka { get { return _marka; } set { _marka = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Renk { get { return _renk; } set { _renk = value; } }
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set
            {
                //girilen sayi 2-4 ise kapi sayisi alanina atatniyor
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    _kapiSayisi = -1;
                    Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır.");
                }
            }
        }
        //car constructorı tanımlanıyor, car nesnesi oluşturulduğunda çağrılıyor.
        public Car(string marka, string model, string renk, int kapiSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi;
        }
    }
}
