
using PracticalImdbList;

List<Film> films = new List<Film>();

while (true)//sonsuz döngü 
{
    Film film = new Film();

    Console.WriteLine("Film Adı :  ");

    film.FilmName = Console.ReadLine();

sorgu:
    Console.WriteLine("IMBD Puanı Giriniz: ");

    film.FilmImdbPuan = Convert.ToDouble(Console.ReadLine());

    if (film.FilmImdbPuan < 0 || film.FilmImdbPuan > 10)
    {
        Console.WriteLine("Lutfen 0 dan büyük. 10 kuçuk bir puan giriniz.");

        goto sorgu;
    }


    films.Add(film);

sorgu2:
    Console.WriteLine("Baska bir film eklemek istemisiniz ? (e/h)");
    string result = Console.ReadLine().ToLower();
    if (result == "e")
    {
        continue;//e dongü başa döner

    }
    else if (result == "h")
    {
        break;

    }
    else
    {
        Console.WriteLine("Cevabınız anlaşılmamıştır, 'e' veya 'h' seçiniz.");
        goto sorgu2; // Geçersiz cevap verildiğinde tekrar sorulacak }

    }
}
Console.WriteLine("**Bütün Filmler **");

foreach (var item in films)
{

    if (item.FilmImdbPuan >=4 && item.FilmImdbPuan<=9)
    {
        Console.WriteLine($"Film: {item.FilmName}, IMDb Puanı: {item.FilmImdbPuan}");
    }



}

Console.WriteLine("** İsmi 'A' ile Başlayan Filmler **");

foreach (var item in films)
{
    if (item.FilmName.Length >0 && item.FilmName.Substring(0,1).ToLower()=="a")
    {
        Console.WriteLine($"Film: {item.FilmName}, IMDb Puanı: {item.FilmImdbPuan}");
    }
}


