// Программа принимет число и выдает сумму цифр в числе

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());


int sumNumber = SumNumber(number);
Console.WriteLine($"{number} -> {sumNumber}");



int SumNumber(int num)
{
    if (num < 0) num = num * -1;
    int count = 0;
    while (num != 0)
    {
        count = count + num % 10;
        num = num / 10;
    }
    return count;
}