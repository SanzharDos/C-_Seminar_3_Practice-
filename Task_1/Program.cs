// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckNum1(int num)
{
    if (num > 99999 || num < 9999) Console.WriteLine ("Вы ввели не пятизначное число!");
    else CheckNum2(num);
}

void CheckNum2(int num)
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
    Console.WriteLine("Введите пятизначное число");
    int num = Convert.ToInt32(Console.ReadLine());
    CheckNum1(num);
}

catch
{
    Console.WriteLine("Надо вводить пятизначное число!");
}
