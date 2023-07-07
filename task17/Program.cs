// Программа которая принимает на вход координаты точки (х и у), которые не равны 0, и выдает номер плоскости в которой находиться эта точка. 

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

if(xCoordinate > 0 && yCoordinate > 0)
{
Console.WriteLine("Указыанные координаты соответствуют четверти 1");
}
else if (xCoordinate < 0 && yCoordinate > 0)
{
Console.WriteLine("Указыанные координаты соответствуют четверти 2");
}
else if (xCoordinate < 0 && yCoordinate < 0)
{
Console.WriteLine("Указыанные координаты соответствуют четверти 3");
}
else if (xCoordinate > 0 && yCoordinate < 0)
{
Console.WriteLine("Указыанные координаты соответствуют четверти 4");
}
else
{
Console.WriteLine("Указанные координаты неверные");
}

// тоже самое, но функциями (можно убрать все {} и else тоже)
//int quarter = Quater(xCoordinate, yCoordinate );
// string result = Quater > 0 ? "Указыанные координаты соответствуют четверти {Quater}" : "Указанные координаты неверные";
// Console.WriteLine($"Указыанные координаты соответствуют четверти {Quater}")
// int Quater (int x, int y)
//{
  //  if (x > 0 && y > 0)
    //return 1;
//}
//else if (x < 0 && y > 0)
//{
  //  return 2;
//}
//else if (x < 0 && y < 0)
//{
//    return 3;
//}
//else if (x > 0 && y < 0)
//{
//    return 4;
//}
//else
//{
 // return 0;  
//}