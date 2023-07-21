// Программа выводит массив из 8 элементов из рандомно располдоженных едениц и нулей.

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int[] arrayNums = new int[number];

arrayNums[4] = 231;

Massive(arrayNums);
printArray(arrayNums);

void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i == arr.Length-1)
        {
            Console.Write("]");
        }
        else
        {
            Console.Write(",");
        }
    }
}

void Massive(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(2);
    }
}
