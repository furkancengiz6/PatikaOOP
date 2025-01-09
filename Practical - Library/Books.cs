using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
       //Kitap sınıfının propertyleri -> Kitap Adı , Yazar Adı , Yazar Soyadı , Sayfa Sayısı , Yayıncı , Yayın Tarihi
    public class Books
    {
        //Propertyler private olarak tanımlandı.
//Propertylerin dışarıdan erişilebilmesi için get ve set metodları yazıldı.
        private string BookName { get; set; }
        private string AuthorName { get; set; }
        private string AuthorSurname { get; set; }
        private int NumberofPages { get; set; }
        private string Publisher { get; set; }
        private DateTime PublishDate { get; set; }
//1.si Default Constructor tarzında parametre almayan bir metot.
        public Books()
        {
            BookName = "";
            AuthorName = "";
            AuthorSurname = "";
            NumberofPages = 0;
            Publisher = "";
            PublishDate = DateTime.Today;
            Console.WriteLine($"Kayit tarihi: {PublishDate}");
        }
    //2.si Ad, Soyad, Sayfa Sayısı ve Yayıncı parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.
        public Books(string bookName, string authorName, string authorSurname, int numberofPages, string publisher)
        {
            BookName = bookName;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            NumberofPages = numberofPages;
            Publisher = publisher;
            PublishDate = DateTime.Today;
            Console.WriteLine($"Kitap Adı : {bookName} , Yazar Adı,Soyadı {authorName},{authorSurname},Sayfa sayisi: {numberofPages},Yayıncı: {publisher}");
            Console.WriteLine($"Kayit tarihi: {PublishDate}");

      //Default Constructor: Parametresiz bir şekilde bir kitap nesnesi oluşturur ve varsayılan değerleri atar.
 // Parameterized Constructor: Kitapla ilgili bilgileri parametre olarak alır ve nesne oluşturma aşamasında bu bilgileri atar.
        }
    }
}
