/*
int CutDigit(int number)
{
    int a = number % 100;
    int b = a / 10;
    int result = b;
    return result;
}
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32 (Console.ReadLine());
int amount = num.ToString().Length;

if (amount < 3 || amount > 3)
{
 Console.WriteLine("Вы ввели не трехзначное число: Попробуй снова, растяпа!");
}
else
{
 Console.WriteLine("Превосходно!");
}

int newNum = CutDigit(num);
if (amount < 3 || amount > 3)
{
 Console.WriteLine($"New user version of {num} is -1");
}
else
{
 Console.WriteLine($"New user version of {num} is {newNum}");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int A(int a, int b)
{
    int result = -1;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
    int c = 1;
    for ( int i = b; i > 3; i--)
    {
        c = c * 10;
    }
result = (a / c) % 10;
}
return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
int count = number.ToString().Length;
int newnumber = A(number, count);
Console.WriteLine(newnumber);
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
int DayWeek(int dayN)
{
if (dayN > 0 && dayN < 8)
{
if (dayN == 7 || dayN == 6)
{
Console.Write("Под цифрой " + dayN + " - Выходной");
}
else
{
Console.Write("Под цифрой " + dayN + " - Рабочий");
}
}
else
{
Console.Write("Дружок-пирожок, вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}
Console.Write(" день.");
return Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите число от 1 до 7: ");
int dayN = Convert.ToInt32 (Console.ReadLine());
int newdayN = DayWeek(dayN);
Console.WriteLine(newdayN);
*/