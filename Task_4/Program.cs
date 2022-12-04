// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.
try
{
    Console.WriteLine("Введите число, которое будет определять скольки мерное пространство");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 0) Console.WriteLine("Введите неотрицательное и целое число");
    int size = n;
    double[] A = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е значение координаты A");
        A[i] = Convert.ToDouble(Console.ReadLine());
    }

    double[] B = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е значение координаты B");
        B[i] = Convert.ToDouble(Console.ReadLine());
    }

    double sum = 0;
    for (int i = 0; i < n; i++)
    {

        sum = sum + Math.Pow((B[i] - A[i]), 2);
    }
    double result = Math.Sqrt(sum);
    Console.WriteLine($"Расстояние между координатами A и B равно = {result}");
}

catch
{
    Console.WriteLine("Надо ввести целое и неотрицательное число!");
}
