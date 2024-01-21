namespace Static_Örnek_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci("Yaşar", 15);
            Ogrenci o2 = new Ogrenci("KEmal", 21);
            Ogrenci o3 = new Ogrenci("Elif", 27);
            Ogrenci o4 = new Ogrenci("Özge", 14);

            Console.WriteLine(Ogrenci.NesneSayisi);

            Ogrenci o5 = new Ogrenci("Aylin", 25);
            Console.WriteLine(Ogrenci.NesneSayisi);
        }
    }
}