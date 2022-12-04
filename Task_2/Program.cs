// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Count(double xa, double xb, double ya, double yb, double za, double zb)
{
double num1 = Math.Pow((xb - xa), 2);
double num2 = Math.Pow((yb - ya), 2);
double num3 = Math.Pow((zb - za), 2);
double result = Math.Sqrt(num1 + num2 + num3);
Console.WriteLine($"Расстояние между координатами А({xa}, {ya}, {za}) и В({xb}, {yb}, {zb}) составляет = {result}");
}

try
{
    Console.WriteLine("Введите значение по X координаты A");
    double xa = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по Y координаты A");
    double ya = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по Z координаты A");
    double za = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по X координаты B");
    double xb = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по Y координаты B");
    double yb = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по Z координаты B");
    double zb = Convert.ToDouble(Console.ReadLine());
    Count(xa, xb, ya, yb, za, zb);
}

catch
{
    Console.WriteLine("Надо ввести число!");
}