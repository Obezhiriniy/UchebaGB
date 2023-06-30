// Прорамма  которая принимает на вход трехзначное число, и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра {number}, это  {lastDigit}");
}
else
{
    Console.WriteLine("Ведено не верное число, введитие корректное трехзначное число");
}