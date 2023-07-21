// Посчитать сколько чисел больше нуля ввел пользователь, при введении им М чисел

Console.WriteLine("введите сколько чисел вы хотети ввести:");
int num = Convert.ToInt32(Console.ReadLine());
int[] temp = NywArrayForNumbs(num);
int result = PositiveNumbsInArray(temp);
Console.WriteLine($"положительных чисел введено:{result}");


int[] NywArrayForNumbs(int numb)
{
    int[] result = new int[numb];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"введите число {i+1} из {numb} :");
        result[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    return result;
}

int PositiveNumbsInArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result ++;
    }
    return result;
}