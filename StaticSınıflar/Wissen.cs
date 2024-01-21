using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSınıflar
{
    public static class Wissen
    {
        public static string Ad { get; set; }

        public static void SayHello()
        {
            Console.WriteLine("Hello");

        }


        // Static bir sınıfın içerisinde sadece static üyeler olabilirt.
        // Non Static bir üye barınamaz, yazsanızda derleme zamanı hatası verecektir.
        //public void Test()
        //{

        //    Console.WriteLine("Static sınıf içerisine non static bir öğe yerleştirilemez");
        //}
    }
}
