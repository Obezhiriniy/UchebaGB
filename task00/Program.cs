// Написать программу, которая на вход принимает число, а на выходе выводит его квадрат. 

//Памятка. Замена команды в строке 7
//  string str = Console.ReadLine()
// int number = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");