// Программа, принимает 2 числа, и выводит является ли  первое, кратным второму. Если нет, программа выводит остаток от деления. 

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int multiplicity = firstNumber % secondNumber;
if (multiplicity == 0)
{
Console.WriteLine("Первое число  кратно второму");

}

else
{
Console.WriteLine($"Первое число не кратно второму,  остаток -> {multiplicity}");
}
