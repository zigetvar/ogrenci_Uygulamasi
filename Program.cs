using System;

namespace ögernciUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Student ögrenci1 = new Student("Kerim","ALTUN",2011404028,80,65,70,"Mehmet Akif Ersoy Üniversitesi");

            Console.WriteLine("Öğrenci Uygulamamıza Hoşgeldiniz... Lütfen Yapmak İstediğiniz İşlemi Seçiniz...");

            while (kontrol)
            {
                islemler();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":

                        ögrenci1.ÖgrenciBilgileriGöster();
                        break;

                    case "2":
                        ögrenci1.ÖgrenciOrtalamasınıBul();
                        break;

                    case "3":
                        ögrenci1.OkulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;


                    
                }
            }


            
            
            
            static void islemler()
            {
                Console.WriteLine("1-Öğrenci Bilgilerini Göster");
                Console.WriteLine("2-Öğrenci Ortalaması Göster");
                Console.WriteLine("3-Öğrenci Okulu Göster");
                Console.WriteLine("4-Çıkış");
            }
        }
    }
}
