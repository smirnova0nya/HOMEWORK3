// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Prompt(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine());
}

double x1 = Prompt("Введите координату X первой точки: ");
double y1 = Prompt("Введите координату Y первой точки: ");
double z1 = Prompt("Введите координату Z первой точки: ");
double x2 = Prompt("Введите координату X второй точки: ");
double y2 = Prompt("Введите координату Y второй точки: ");
double z2 = Prompt("Введите координату Z второй точки: ");
double x = x2 - x1;
double y = y2 - y1;
double z = z2 - z1;
double rast = Math.Sqrt(x*x + y*y + z*z);
Console.WriteLine($"Расстояние между точками равно {rast:f2}");