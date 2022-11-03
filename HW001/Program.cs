// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. //

/*
int a = 500; 
int b = 78;
 
int max = a;
int min = b;

if (a>max) max = a;
if (b>max) max = b;

Console.Write("max = ");
Console.WriteLine(max);

if (a<min) min = a;
if (b<min) min = b;

Console.Write("min = ");
Console.WriteLine(min);
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input number_1: ");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input number_2: ");
int number_2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input number_3: ");
int number_3 = Convert.ToInt32 (Console.ReadLine());

int max = 0;

if (number_1 > max) max = number_1;
if (number_2 > max) max = number_2;
if (number_3 > max) max = number_3;

Console.Write("max = ");
Console.WriteLine(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number_1: ");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input number_2: ");
int number_2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input number_3: ");
int number_3 = Convert.ToInt32 (Console.ReadLine());

int even_number_1 = 0;
int even_number_2 = 0;
int even_number_3 = 0;

if (number_1 >= 0) 
 {
even_number_1 = number_1;
Console.WriteLine("Высказывание  (Ровно одно из чисел number_1, number_2, number_3 положительное) ИСТИННО)");
 }

else
{
Console.WriteLine("Высказывание  (Ровно одно из чисел number_1, number_2, number_3 положительное) ЛОЖЬ");
}

Console.Write("even_number_1 = ");
Console.WriteLine(even_number_1);

if (number_2 >= 0) 
 {
even_number_2 = number_2;
Console.WriteLine("Высказывание  (Ровно одно из чисел number_1, number_2, number_3 положительное) ИСТИННО)");
 }

else
{
Console.WriteLine("Высказывание  (Ровно одно из чисел number_1, number_2, number_3 положительное) ЛОЖЬ");
}

Console.Write("even_number_2 = ");
Console.WriteLine(even_number_2);

if (number_3 >= 0) 
{
even_number_3 = number_3;
Console.WriteLine("Высказывание  (Ровно одно из чисел number_1, number_2, number_3 положительное) ИСТИННО)");
}

else
{
Console.WriteLine("Высказывание  (Ровно одно из чисел number_1, number_2, number_3 положительное) ЛОЖЬ");
}

Console.Write("even_number_3 = ");
Console.WriteLine(even_number_3);
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input  a positive integer number: ");
int number = Convert.ToInt32 (Console.ReadLine());

int current = 1 - number;

if (number % 2==1)
{
Console.WriteLine("число нечетное");
}
else
{
Console.WriteLine("Число четное");
}
 
while (current <= number)
{
Console.Write(current + " ");
current++;
}
*/
// Задача номер 8 не задалась, надо более времени!!!