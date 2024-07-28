

Console.Write("Lütfen bir sayı giriniz: ");
int number = int.Parse(Console.ReadLine());


if (number == 10)
{
    Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
}
else if (number < 10)
{
    Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
}


if (number % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}