using System;
using System.Collections.Generic;

namespace KyafetSatis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ürünlerin sayısını tutmak için bir sözlük kullanıyoruz
            Dictionary<string, int> depo = new Dictionary<string, int>();
            depo.Add("T-shirt", 100);
            depo.Add("Pantolon", 50);
            depo.Add("Ceket", 30);

            // Satış işlemi için bir döngü
            while (true)
            {
                Console.WriteLine("Satmak istediğiniz ürünün türünü girin (T-shirt, Pantolon, Ceket, Çıkış için 'q'):");
                string urunTuru = Console.ReadLine();

                if (urunTuru.ToLower() == "q")
                {
                    break;
                }

                Console.WriteLine("Kaç adet satmak istiyorsunuz?");
                int satisAdedi = int.Parse(Console.ReadLine());

                switch (urunTuru.ToLower())
                {
                    case "t-shirt":
                        if (depo["T-shirt"] >= satisAdedi)
                        {
                            depo["T-shirt"] -= satisAdedi;
                            Console.WriteLine($"{satisAdedi} adet T-shirt satıldı.");
                        }
                        else
                        {
                            Console.WriteLine("Yeterli T-shirt stoğu bulunmamaktadır.");
                        }
                        break;
                    case "pantolon":
                        // Pantolon için benzer işlemler
                        break;
                    case "ceket":
                        // Ceket için benzer işlemler
                        break;
                    default:
                        Console.WriteLine("Geçersiz ürün türü.");
                        break;
                }

                Console.WriteLine("Depodaki mevcut ürün sayısı:");
                foreach (var item in depo)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}