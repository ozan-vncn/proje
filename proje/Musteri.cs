using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    interface IINSAN
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        
            
    }
    class Musteri:IINSAN
    {
        private string _ad;
        private string _soyad;
        private int _telefon;
        public string musteri;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
     
        void bilgiGetir()
        {
            musteri = "Adı: " + Ad + "Soyadı:" + Soyad;
        }
    }
}
