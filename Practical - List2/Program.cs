



List<string> cafeList = new List<string>();

for (int i = 1; i <6; i++)
{
    Console.Write($"Kahve {i} :");
    string input  = Console.ReadLine();
    cafeList.Add(input);
}
Console.WriteLine("Girilen Kahve İsimleri:");
foreach ( string cafe in cafeList) {  Console.WriteLine( cafe ); }