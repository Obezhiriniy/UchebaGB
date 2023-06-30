// Программа которая на вход принимает число и выдает являеться ли оно четным
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 2;
if (lastDigit == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
