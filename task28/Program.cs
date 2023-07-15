// Программа принимает число N, и выдает произвведение чисел от 1 до N

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int result = Factorial(number);
Console.WriteLine($"{number} -> {result}");



int Factorial(int num)
{
    int fac = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            fac = fac * i;
        }
    }
    return fac;
}