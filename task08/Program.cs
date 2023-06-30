// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count =1;
if (number <= 0);
{
  Console.WriteLine("Введите целое положительное число"); 
}
while (count <= number)
{
    if (count % 2 ==0)
    {
        Console.WriteLine($"{count}");
    }
    count++;
}