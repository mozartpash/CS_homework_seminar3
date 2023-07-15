// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Result(int num)
{
    if (num > 9999 && num < 100000)
    {
        int a = num / 10000;
        int b = num / 1000 % 10;
        int c = num % 10;
        int d = num % 100 / 10;
        //Console.WriteLine (a + "," + b + "," + c + "," + d);
        if (a == c && b == d)
        {
            Console.WriteLine("Ваше число является палиндромом");
        }
        else
            Console.WriteLine("Ваше число НЕ является палиндромом");
    }
    else
        Console.WriteLine("Ваше число НЕ является пятизначным");
}

int number = GetNumber("Введите пятизначное число число: ");
Result(number);