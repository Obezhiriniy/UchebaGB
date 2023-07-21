// Создать одномерный массив из 123 чисел, и найти кол-во элементов массива лежащих в отрезке от 10 до 99


int[] CreateArrayRndInt(int size, int min = -10, int max = 10)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ", ")
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}{sep}");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
}

int CountTwoDigitNumbers(int[] arr)
{
    int countTwo = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            countTwo += 1;
        }
    }
    return countTwo;
}



int[] array = CreateArrayRndInt(123, -1000, 1000);
int result = CountTwoDigitNumbers(array);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");
Console.WriteLine("-->");
Console.WriteLine($"количество положительных двухзначных чисел = {result}");