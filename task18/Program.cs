// Программа, которая по заданному номеру четверти показывает диапозон возможных координат точек в этой четверти.

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());
string range = Range(quarter);
string result = range == null ? "Указана неверная четверть" : $"Диапозон возможных координат точек в этой четверти: {range}";
Console.WriteLine(result);
string Range(int qua)

{
 if (qua == 1) return "x > 0 && y > 0";
 if (qua == 2) return "x < 0 && y > 0";
 if (qua == 3) return "x > 0 && y < 0";
 if (qua == 4) return "x < 0 && y > 0";
 return null; 
}
