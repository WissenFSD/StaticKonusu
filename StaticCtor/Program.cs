using System.Net.WebSockets;

namespace StaticCtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static üyeler, nesneye değil sınıfın elemanlarıdır.

            // Peki o zaman ? static bir üye ne zaman belleğe çıkar.


            Araba.Ad = "Renault";
            Console.WriteLine(Araba.Ad);

            Araba.Ad = "Ferrari";
            Console.WriteLine(Araba.Ad);



            Araba.Ad = "Fiat";
            Console.WriteLine(Araba.Ad);


        }
    }
}