// Программа принимает на вход одно число (N),а на входе показывает все целые число от  -N до N.

Console.WriteLine("Введите натуральное (целое положительное) число");
int number = Convert.ToInt32(Console.ReadLine());
int count = number * -1;
while (count <= number);
{
    Console.Write($"{count} ");
    count = count + 1;
}
