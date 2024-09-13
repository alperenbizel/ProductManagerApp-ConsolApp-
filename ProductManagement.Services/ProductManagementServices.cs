using System;
using System.Collections.Generic;
using ProductManagement.Models.Concreate;
using ProductManagement.Models.Interface;

namespace ProductManagement.Services
{
    public class ProductManagementServices : IEntity
    {
        private List<ElectronicProduct> electronicProducts = new List<ElectronicProduct>();
        private List<GroceryProduct> groceryProducts = new List<GroceryProduct>();

        public void UrunEkle()
        {
            while (true)
            {
                Console.WriteLine("Hangi ürünü eklemek istersiniz?" +
                                  "\n1- Manav" +
                                  "\n2- Elektronik ürün");
                string cevap = Console.ReadLine();

                switch (cevap)
                {
                    case "1":
                        AddGroceryProduct();
                        break;

                    case "2":
                        AddElectronicProduct();
                        break;

                    default:
                        Console.WriteLine("Yanlış işlem, lütfen tekrar deneyin.");
                        continue; 
                }
                break; 
            }
        }
        // Burada  ürünl ekledik
        private void AddGroceryProduct()
        {
            Console.WriteLine("Eklemek istediğiniz ürünün adını girin:");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} adlı ürünün fiyatını girin:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ürün taze mi? (Evet/Hayır):");
            bool fresh = Console.ReadLine().ToLower() == "evet";

            var newProduct = new GroceryProduct(name, price, fresh);
            groceryProducts.Add(newProduct);

            Console.WriteLine("Manav ürünü başarıyla eklendi.");
        }

        private void AddElectronicProduct()
        {
            Console.WriteLine("Eklemek istediğiniz ürünün adını girin:");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} adlı ürünün fiyatını girin:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ürünün garanti süresini giriniz (ay):");
            int warrantyInMonths = Convert.ToInt16(Console.ReadLine());

            var newProduct = new ElectronicProduct(name, price, warrantyInMonths);
            electronicProducts.Add(newProduct);

            Console.WriteLine("Elektronik ürün başarıyla eklendi.");
        }

        public void UrunListeleme()
        {
            Console.WriteLine("\nElektronik Ürünler:");
            //listenin count değer,n, kontrol ettik  eğer liste değilse yazdıkrık boşsa hata mesajı verdik
            if (electronicProducts.Count > 0)
            {
                foreach (var product in electronicProducts)
                {
                    Console.WriteLine($"Ürün Adı: {product.Name}, Fiyat: {product.Price}, Garanti Süresi (ay): {product.WarrantyInMonths}");
                }
            }
            else
            {
                Console.WriteLine("Elektronik ürün bulunmuyor.");
            }

            Console.WriteLine("\nManav Ürünleri:");
            if (groceryProducts.Count > 0)
            {
                foreach (var product in groceryProducts)
                {
                    Console.WriteLine($"Ürün Adı: {product.Name}, Fiyat: {product.Price}, Taze mi: {product.Fresh}");
                }
            }
            else
            {
                Console.WriteLine("Manav ürünü bulunmuyor.");
            }
        }

        public void UrunSilme()
        {
            Console.WriteLine("Silmek istediğiniz ürün türünü seçin:" +
                              "\n1- Manav" +
                              "\n2- Elektronik");
            string cevap = Console.ReadLine();

            switch (cevap)
            {
                case "1":
                    RemoveGroceryProduct();
                    break;

                case "2":
                    RemoveElectronicProduct();
                    break;

                default:
                    Console.WriteLine("Yanlış işlem.");
                    break;
            }
        }

        private void RemoveGroceryProduct()
        {// hocam burda yine kontrol ettik  çünkü eğer boşsa uygulama hata verir
            if (groceryProducts.Count == 0)
            {
                Console.WriteLine("Manav ürünü bulunmuyor.");
                return;
            }

            Console.WriteLine("Silmek istediğiniz manav ürününün adını girin:");
            string name = Console.ReadLine();
            // burda ürünlerin adını aradık eğer eşitse sildik değilse hata mesajı verdik
            var productToRemove = groceryProducts.Find(p => p.Name == name);

            if (productToRemove != null)
            {
                groceryProducts.Remove(productToRemove);
                Console.WriteLine($"{name} adlı manav ürünü silindi.");
            }
            else
            {
                Console.WriteLine($"{name} adlı manav ürünü bulunamadı.");
            }
        }

        private void RemoveElectronicProduct()
        {
            if (electronicProducts.Count == 0)
            {
                Console.WriteLine("Elektronik ürün bulunmuyor.");
                return;
            }

            Console.WriteLine("Silmek istediğiniz elektronik ürünün adını girin:");
            string name = Console.ReadLine();
           
            var productToRemove = electronicProducts.Find(p => p.Name == name);

            if (productToRemove != null)
            {
                electronicProducts.Remove(productToRemove);
                Console.WriteLine($"{name} adlı elektronik ürün silindi.");
            }
            else
            {
                Console.WriteLine($"{name} adlı elektronik ürün bulunamadı.");
            }
        }
    }
}
