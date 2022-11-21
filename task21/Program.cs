// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
int x1 = CoordinatesX();
int y1 = CoordinatesY();
int z1 = CoordinatesZ();

Console.WriteLine("Введите координаты второй точки");
int x2 = CoordinatesX();
int y2 = CoordinatesY();
int z2 = CoordinatesZ();

int CoordinatesX()
{
    Console.WriteLine("Введите координату Х: ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int CoordinatesY()
{
    Console.WriteLine("Введите координату Y: ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int CoordinatesZ()
{
    Console.WriteLine("Введите координату Z: ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
}

double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(result);