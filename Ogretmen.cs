﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Ogretmen:Personel
    {
        public override void maasHesapla()
        {
            base.maasHesapla();
            if (haftalikCalismaSaati <= 20)
            {
                this.maas = maas * 4;
            }
            else
            {
                this.maas = (maas * 4) + ((haftalikCalismaSaati - 20) * 200);
            }
        }
    }
}