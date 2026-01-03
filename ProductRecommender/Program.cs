using System;

namespace ProductRecommender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Akıllı Ürün Öneri Sistemi (Two Pointers) ---\n");

            int[] sortedPrices = { 50, 150, 200, 350, 500, 750, 1000, 1200, 1500, 2000 };
            int targetBudget = 1350;

            Console.WriteLine($"Mevcut Ürün Fiyatları: [{string.Join(", ", sortedPrices)}]");
            Console.WriteLine($"Müşteri Bütçesi: {targetBudget} TL\n");

            RecommendationEngine engine = new RecommendationEngine();
            int[] resultIndices = engine.FindProductPair(sortedPrices, targetBudget);

            if (resultIndices != null)
            {
                int index1 = resultIndices[0];
                int index2 = resultIndices[1];
                int price1 = sortedPrices[index1];
                int price2 = sortedPrices[index2];

                Console.WriteLine("✅ EŞLEŞME BULUNDU!");
                Console.WriteLine($"Önerilen Paket: Ürün #{index1} ({price1} TL) + Ürün #{index2} ({price2} TL)");
                Console.WriteLine($"Toplam: {price1 + price2} TL");
            }
            else
            {
                Console.WriteLine("❌ Bu bütçeye tam uygun ikili paket bulunamadı.");
            }

            Console.ReadLine();
        }
    }
}
