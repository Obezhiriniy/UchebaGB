// Программа замены элементов массива положительных на отрицательные элементы. и наоборот.

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

void ArrayInverse(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = CreateArrayRndInt(5, -9, 9);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");
Console.WriteLine("");
ArrayInverse(array);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");