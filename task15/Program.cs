// Программа принимает число, и выводит, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельник,будний день");
}
else if (number == 2)
{
    Console.WriteLine("Вторник, все еще рабочий");
}
else if (number == 3)
{
    Console.WriteLine("Среда, рабочий день");
}
else if (number == 4)
{
    Console.WriteLine("Четверг, пбудний, продолжаем работать");
}
else if (number == 5)
{
    Console.WriteLine("Пятница, завтра выходной, но пока работаем");
}
else if (number == 6)
{
    Console.WriteLine("Субботка, отдыхаем");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье, выходной, но завтра на работу.");
}
else
{
    Console.WriteLine("В неделе семь дней, введите корректный номер");
}