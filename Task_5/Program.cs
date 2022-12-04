// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

void CheckNum(int num)
{
    int temp = num;
    int check = 0;
    while (temp != 0)
    {
        check = check * 10 + temp % 10;
        temp = temp / 10;
    }
    if (check == num) Console.WriteLine($"Число {num} - палиндром");
    else Console.WriteLine($"Число {num} - не палиндром");
}

try
{
    Console.WriteLine("Введите любое целое число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0) num = -num;
    CheckNum(num);
}

catch
{
    Console.WriteLine("Надо вводить целое число!");
}