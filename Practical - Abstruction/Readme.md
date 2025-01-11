# Practical - Abstraction

Bu proje, Nesne Yönelimli Programlama (OOP) yaklaşımı ile soyutlama (abstraction) konseptini anlamak ve uygulamak amacıyla hazırlanmıştır. Çalışma, bir şirketin çalışanlarını temsil eden bir yapıyı modellemektedir.

## Proje Özeti

- **BasePerson (Soyut Sınıf)**:
  - Çalışanların ad, soyad ve departman gibi ortak özelliklerini içerir.
  - Tüm çalışanların görevlerini tanımlamak için bir `Gorev` adlı soyut metot içerir.
  
- **Türetilen Sınıflar**:
  - **ProjectManager**: Proje yöneticisi olarak görev yapan çalışanları temsil eder.
 
  
- **Görev**:
  Her çalışan sınıfı, `Gorev` metodunu kendi iş tanımına göre özelleştirir. Bu metod çağrıldığında, çalışanların yaptığı iş konsola yazdırılır.

## Örnek Kullanım

Aşağıdaki kod parçacığı, `Main` metodunda çalışan nesnelerinin oluşturulmasını ve görevlerinin çağrılmasını göstermektedir:

```csharp
var projectManager = new ProjectManager("Hasan", "Çıldırmış", "Proje Yönetimi");


Console.WriteLine(projectManager.ToString());
projectManager.Gorev();




