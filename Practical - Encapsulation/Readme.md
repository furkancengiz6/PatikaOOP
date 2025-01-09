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
```
