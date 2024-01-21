using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Örnek_
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        // Her bir nesne oluştuğunda sayı bir artacak
        public static int NesneSayisi { get; set; }

        public Ogrenci()
        {
            NesneSayisi++;
        }
        public Ogrenci(string ad,int yas):this()
        {
            this.Ad = ad;
            this.Yas = yas;
        }

    }
}
