# Smart Product Recommender (Two Pointers Algorithm)

Bu proje, bir E-ticaret senaryosunda müşterinin belirli bir bütçeyi (hediye çeki, kupon vb.) tam olarak harcayabileceği **iki ürünü** bulmak için geliştirilmiş, yüksek performanslı bir C# konsol uygulamasıdır.

## Proje Amacı ve Senaryo

E-ticaret platformlarında müşterilerin sepet tutarını belirli bir limite tamamlamaları veya ellerindeki hediye çekini (Voucher) tam değeriyle kullanmaları istenir.

**Problem:** Veritabanımızda fiyatına göre küçükten büyüğe sıralı binlerce ürün var. Müşterinin `2000 TL`'lik bir çeki var. Toplamı tam olarak `2000 TL` eden iki farklı ürünü en hızlı şekilde nasıl buluruz?

## Kullanılan Algoritma: Two Pointers

Bu problemi çözmek için **Two Pointers (İki İşaretçi)** tekniği kullanılmıştır.

### Neden Two Pointers?
* **Brute Force (Kaba Kuvvet):** Her ürünü diğer tüm ürünlerle tek tek denemek (iç içe döngü) `O(n²)` zaman karmaşıklığı yaratır. 10.000 ürünlük bir listede bu 100 milyon işlem demektir.
* **Two Pointers:** Sıralı dizinin başından (en ucuz) ve sonundan (en pahalı) başlayarak merkeze doğru ilerler. Diziyi sadece tek bir geçişte tarar.
* **Zaman Karmaşıklığı:** `O(n)` - Lineer zaman.

### Kod Mantığı (Logic)
Dizi **sıralı** olduğu için şu strateji uygulanır:
1.  `Left` (En ucuz) ve `Right` (En pahalı) ürünler toplanır.
2.  `Toplam == Hedef` ise: Eşleşme bulundu! 
3.  `Toplam < Hedef` ise: Tutar az geldi. `Left` işaretçisi sağa kaydırılarak daha pahalı bir ürün seçilir (Toplam büyütülür).
4.  `Toplam > Hedef` ise: Tutar fazla geldi. `Right` işaretçisi sola kaydırılarak daha ucuz bir ürün seçilir (Toplam küçültülür).

## Örnek Çıktı

```text
--- Akıllı Ürün Öneri Sistemi (Two Pointers) ---

Mevcut Ürün Fiyatları: [50, 150, 200, 350, 500, 750, 1000, 1200, 1500, 2000]
Müşteri Bütçesi: 1350 TL

✅ EŞLEŞME BULUNDU!
Önerilen Paket: Ürün #3 (350 TL) + Ürün #6 (1000 TL)
Toplam: 1350 TL
