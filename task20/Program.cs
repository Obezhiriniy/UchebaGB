// Программа которая принимает кооординаты 2-х точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты X точки 1");
Console.WriteLine("Введите координаты Y точки 1");
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки 2");
Console.WriteLine("Введите координаты Y точки 2");
int b1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(a1, a2, b1, b2);
double resultRound = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками {resultRound}");

double Distance(int x1, int y1, int x2, int y2);
{
    int cat1 = x1 - x2;
    int cat2 = y1 - y2;
    double dist = Math.Sqrt (cat1 * cat1 + cat2 * cat2);
    return dist;
}
