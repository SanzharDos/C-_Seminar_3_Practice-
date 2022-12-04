// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Count(int n)
{
    if (n < 0) n = -n;
    for (int i = 1; i <= n; i++)
    {
        double num = Math.Pow(i, 3);
        Console.Write($"{num} ");
    }
}

try
{
    Console.WriteLine("Введите целое число");
    int n = Convert.ToInt32(Console.ReadLine());
    Count(n);
}

catch
{
    Console.WriteLine("Надо ввести целое число!");
}