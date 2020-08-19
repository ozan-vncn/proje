using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    interface IURUN
    {
      
        string Urun { get; set; }
        string SeriNo { get; set; }
        string ArizaNedeni { get; set; }
    }
    class Urunler:IURUN
    {
        private string _urun;
        private string _seriNo; 
        private string _arizaNedeni;
        
       
        public string Urun
        {
            set { _urun = value; }
            get { return _urun; }
        }
        public string SeriNo         
        {
            set { _seriNo = value; }
            get { return _seriNo; }
        }
        public string ArizaNedeni
        {
            set { _arizaNedeni = value; }
            get { return _arizaNedeni; }
        }

    }
}
