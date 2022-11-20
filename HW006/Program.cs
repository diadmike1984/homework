// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 10-1);

    return array;     
}

void ShowArray(int[] array)
{
    Console.Write("Array is: ");

    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}

Console.Write("Input  a number of elements: ");
int sizeN = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(sizeN);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine(Count(myArray));
*/
// Не смог реализовать программу без массива, ушло много времени и так не сообразил..... И всё же интересно, не могли бы Вы прислать решение в ответ? Спасибо!!!


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
double Coordinates( double b1, double k1, double b2, double k2)
{
    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
    
    if((b1 == b2) && ( k1 == k2))
    {
        Console.Write("Прямые совпадают !!!");
    }
    else if( k1 == k2)
    {
        Console.Write("Прямые параллельны !!!");
    }
    Console.WriteLine();
    return 0;

}


Console.Write("Введите координату b1 первой точки: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату k1 первой точки: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату b2 первой точки: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату k2 первой точки: ");
double k2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine(Coordinates(b1,k1,b2,k2));
*/