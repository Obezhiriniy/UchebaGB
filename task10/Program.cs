// Программа принимает трехзначное число, и на выходе показывает вторую цифру,этого числа
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10 ;
    Console.WriteLine($"Вторая цифра {number}, это {secondDigit}");
}
else
{
    Console.WriteLine("Ведено не верное число, введитие корректное трехзначное число");
}