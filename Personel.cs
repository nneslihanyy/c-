using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Personel
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public double maas { get; set; }
        public int haftalikCalismaSaati { get; set; }

        public virtual void maasHesapla()
        {
            maas = 2000;
        }


    }
}