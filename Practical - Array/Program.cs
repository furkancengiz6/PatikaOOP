
//10 adet tam yası verisi alacak dizi.
int[] praticalArray = new int[10];
Random rnd = new Random();
for (int i = 0; i < praticalArray.Length; i++)
{


    praticalArray[i] = rnd.Next(1, 11);



}
foreach (var item in praticalArray)
{
    Console.WriteLine(item);
}

Console.WriteLine("Diziye 11.elemanı ekleyiniz : ");

int newElement = Convert.ToInt32(Console.ReadLine());

//burada bir sorunla karşılaşıyoruz dizi sabit boyutlu olmasından kaynaklı hata.
//bunun için yeni bir dizi yapalım boyutunu 1 artıralım ve ilk dizimizi aktarıp sonra 11.elemanızı ekleyip büyükten küçüğe sırayalım.

//yeni array oluşturuldu +1 eklendi uzunluğuna
int[] newArray = new int[praticalArray.Length + 1];

//yeni arrayimize eski arrayin elemanları atandı.
for (int i = 0; i < praticalArray.Length; i++)
{
    newArray[i] = praticalArray[i];
}


newArray[newArray.Length - 1] = newElement;

Array.Sort(newArray);
Array.Reverse(newArray);
Console.WriteLine("Büyükten Küçüğe :");
foreach (var item in newArray)
{
    Console.WriteLine(item);
}
