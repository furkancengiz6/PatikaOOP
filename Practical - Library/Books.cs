using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    public class Books
    {
        private string BookName { get; set; }
        private string AuthorName { get; set; }
        private string AuthorSurname { get; set; }
        private int NumberofPages { get; set; }
        private string Publisher { get; set; }
        private DateTime PublishDate { get; set; }

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


        }
    }
}
