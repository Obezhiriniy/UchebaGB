// задать массив из 12 случайных чисел от -9 до 9.
// найти сумму всех отрицательных и положитекльных чисел 

int[] CreateArrayRndInt(int size, int min, int max)
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


int[] GetSumPositiveNegativElem(int[] arr)
{
    int sumPositive =0;
    int sumNegative =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
    return new int[]{sumPositive, sumNegative };


}

int GetSumPositive(int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) sum += arr[i];
    }
    return sum;
}
int GetSumNegative(int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<0) sum += arr[i];
    }
    return sum;
}


int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");

int[] sumPositiveNegativElem = GetSumPositiveNegativElem(array);
Console.WriteLine($"сумма положительных элементов = {sumPositiveNegativElem[0]}");
Console.WriteLine($"сумма негативных элементов = {sumPositiveNegativElem[1]}");

Console.WriteLine(" ");

int sumPositiveElem = GetSumPositive(array);
int sumNegativeElem = GetSumNegative(array);
Console.WriteLine($"сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"сумма негативных элементов = {sumNegativeElem}");