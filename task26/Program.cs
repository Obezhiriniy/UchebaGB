// Программа принимает число, и выдает кол-во цифр в числе

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int lengthNumber = LengthNumber(number);
Console.WriteLine($"{number} -> {lengthNumber}");



int LengthNumber(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}