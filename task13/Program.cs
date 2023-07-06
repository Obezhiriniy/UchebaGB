// Программа выводит третью цифру заданного числа, или  сообщает что ее нет.  

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;
if (number >= 100)
{
    while (number > 999)
    {
        number /= 10;
    }
Console.WriteLine($"Третья цифра числа {number % 10}");
}
else 
{
   Console.WriteLine("Нет третьей цифры");
}


