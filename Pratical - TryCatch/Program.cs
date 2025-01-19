Console.WriteLine("Lütfen bir sayı giriniz:");
string input = Console.ReadLine();
try
{
    
    double number = double.Parse(input);
    if (number < 0)
    {
        Console.WriteLine("Negatif hatalı islem");
    }
    else
    {

        Console.WriteLine($"Karekok : {Math.Sqrt(number)}");

    } 
}
catch (FormatException)
{
    
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
}