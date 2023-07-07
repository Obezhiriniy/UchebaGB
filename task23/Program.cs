// Программа которая принимает на вход число N и выдает таблицу кубов от 1 до N
Console.WriteLine("Введите положительное целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    TableSquare(number);
}
else
{
    Console.WriteLine("Ошибка ввода");
}
void TableSquare(int num);
int count = 1;
while (count <= num)
{
    Console.WriteLine($"{count} {count * count * count}");
    count++;
}