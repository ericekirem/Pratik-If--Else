

Console.Write("Lütfen bir sayı giriniz: ");
//Take number from user
int number = int.Parse(Console.ReadLine());
//Parse number to int

//Compare the number with 10
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

//Check if the number is even or odd
if (number % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}