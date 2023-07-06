// Программа принимает 2 числа, и проверяет являеться ли одно, квадратом второго

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число, является квадратом второго");
}
else if (number2 == number1 * number1)
{
    Console.WriteLine("Второе число, является квадратом первого");
}
else
{
    Console.WriteLine("Ни одно из чисел, не является квадратом другого");
}