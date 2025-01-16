Console.WriteLine("Patika Plus Gala Gecesine Hoşgeldiniz.");

List<string> patikaGalaList = new List<string>()
{
    "Bulent Ersoy",
    "Ajda Pekkan",
    "Ebru Gundes",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};
Console.WriteLine("** Davetliler **");

int sıra = 1;//sıra numarası 

foreach (var item in patikaGalaList)
{
    Console.WriteLine($"{sıra} - {item}");
    sıra++;
}
