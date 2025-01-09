# Practical - Encapsulation

Bu proje, **kapsülleme (encapsulation)** kavramını anlamak ve gerçek hayatta nasıl kullanılabileceğini göstermek için hazırlanmıştır. Projede, bir **Araba (Car)** sınıfı oluşturulmuş ve kapsülleme örneği uygulanmıştır.

---

## 🛠️ Özellikler

- **Araba Sınıfı (Car):**
  - Özellikler:
    - `Brand` (Marka)
    - `Model` (Model)
    - `Color` (Renk)
    - `DoorCount` (Kapı Sayısı - Kapsülleme uygulanmıştır)
  - **Kapı Sayısı (DoorCount):**
    - Yalnızca 2 veya 4 değerleri kabul edilir.
    - Geçersiz bir değer girildiğinde, kullanıcıya uyarı verilir ve varsayılan olarak `-1` atanır.

---

## 💻 Kullanım

### 1️⃣ **Araba Oluşturma**
```csharp
Car car1 = new Car("Toyota", "Corolla", "Beyaz", 4); // Geçerli kapı sayısı
Car car2 = new Car("Honda", "Civic", "Kırmızı", 3); // Geçersiz kapı sayısı

## 2️⃣ Çıktı

-    Geçerli kapı sayısı:
```
Araba oluşturuldu:
Marka: Toyota, 
Model: Corolla, 
Renk: Beyaz, 
Kapı Sayısı: 4
```
-    Geçersiz kapı sayısı:
```
Geçersiz kapı sayısı (3). Kapı sayısı yalnızca 2 veya 4 olabilir. Varsayılan değer atanıyor: -1.
Araba oluşturuldu:
Marka: Honda, 
Model: Civic, 
Renk: Kırmızı, 
Kapı Sayısı: -1
```
## 📚 Kapsülleme (Encapsulation) Nedir?

Kapsülleme, bir sınıfın verilerini (özelliklerini) dış müdahalelerden korumak ve bu verilere kontrollü erişim sağlamak için kullanılan bir OOP prensibidir.
## Bu projede nasıl uygulanmıştır?

    DoorCount özelliği, yalnızca belirli kurallar (2 veya 4 olması) çerçevesinde atanabilir.
    Kontrol, bir property aracılığıyla yapılır:
```
if (value == 2 || value == 4)
{
    doorCount = value;
}
else
{
    Console.WriteLine("Kapı sayısı hatalı! Varsayılan değer atanıyor: -1.");
    doorCount = -1;
}
```
## 🔗 İlgili Konular

    Nesne Yönelimli Programlama (OOP)
    Kapsülleme (Encapsulation)
    Sınıflar ve Özellikler (Classes & Properties)

## 🤝 Katkı

Katkıda bulunmak için lütfen bu repo üzerinde bir pull request oluşturun veya herhangi bir öneri için issue açabilirsiniz. 🎉
## 📜 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.
## 📬 İletişim

Fikirleriniz veya önerileriniz için bana ulaşabilirsiniz:

    GitHub: furkancengiz6
