// Программа которая на входе принимает 2 числа, и проверяет евляеться ли 1-я квадратов 2-го

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число являеться квадратом второго");
}
else
{
    Console.WriteLine("Первое число не являеться квадратом второго");
}