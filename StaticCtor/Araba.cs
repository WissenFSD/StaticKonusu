using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCtor
{
    public  static class Araba
    {
        public static Guid SasiNo { get; set; }
        public static string Ad { get; set; }

        static Araba()
        {

            // Static ctor sadece bir kere çalışır.

            // Static olan sınıf ilk kullanıldığında bir kere static ctor çalışır. Static bellege giderken istediğiniz veriyi static ctor içerisinde tanımlayabilirsiniz.
            // Static ctor asla sınıf kullanım sayısı kadar çalışmaz.

            // Static ctor bir kere ve sınıf ilk kullanıldığında çalışır.

            // Static sınıflar belleğin static alanında dururlar ve bellekten biz istemedikçe ve uygulama kapanmadıkça silinmezler.
            Guid sasiNo = Guid.NewGuid();
        }
    }
}
