// Программа на вход принимает 2 числа, и выдает какое больше, а какое меньше. 
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"{number1},большее число. {number2}, меньшее число ");
}
else
{
    Console.WriteLine($"{number2},большее число. {number1}, меньшее число ");
}