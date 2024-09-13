using System;
using ProductManagement.Services;


namespace ProductManagement.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ProductManagementServices sınıfını başlatıyoruz
            ProductManagementServices productManagement = new ProductManagementServices();

            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:" +
                                  "\n1- Ürün Ekle" +
                                  "\n2- Ürün Listele" +
                                  "\n3- Ürün Sil" +
                                  "\n4- Çıkış");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        productManagement.UrunEkle();
                        break;

                    case "2":
                        productManagement.UrunListeleme();
                        break;

                    case "3":
                        productManagement.UrunSilme();
                        break;

                    case "4":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return; // Programı sonlandırır

                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
