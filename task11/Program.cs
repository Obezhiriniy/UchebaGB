// Программа выводит случайное трехзначное число и удаляет вторую его цифру.

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число {number}");
int firstDigit = number / 100;
int lastDigit = number % 10;
int result = firstDigit * 10 + lastDigit;
Console.WriteLine($"Итоговое число без второй цифры {result} ");