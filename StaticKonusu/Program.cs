namespace StaticKonusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İçerisinde bulunduğu sınıftan nesne oluşlturulmadan ceya hiç bir nesneye referansı olmadan kullanılabilen üyeler static olarak nitelendirilir. Metotlar ve hatta sınıflar static olabilir.

            // NonStaticde tüm elemanlar her zaman nesneye aittir
            Ogrenci o = new Ogrenci();
            o.SayHello();


            // Static'te ise tüm elemanlar sınıfa aittir

            // SayMerhaba metodu static bir metottur. Her zaman nesneden daha hızlı ve daha önce oluşur ve kullanılabilir olur.
            Ogrenci.SayMerhaba();


            // c# da da static olan metotlara erişmek mümkün.
            // 
            // Örnegin Math sınıfına ait tüm metotlar static olarak tanımlanmıştır

            // Buradan anlaşılcağı üzere. Bir sınıfın static üyeleri nesneye gerek kalmadan direk hızlı kullanım için static kullanılmıştır.



        }
    }
}