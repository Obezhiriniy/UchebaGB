// программа, которая будет преобразовывает десятичное число в двоичное.

Console.WriteLine("введите число для конвертации");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DecToBin(number));

/*
int DecToBin(int numb)
{
    int result = 0;
    int factor = 1;
    while (numb != 0)
    {
        result = result + numb % 2 * factor;
        numb /= 2;
        factor*=10;
    }
    return result;
}
*/

 string DecToBin(int numb)
 {
    string result = string.Empty;
    while (numb != 0)
    {
        result = numb % 2 + result;
        numb /= 2;
    }
    return result;
}