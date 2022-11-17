//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000-1);

    return array;     
}

void ShowArray(int[] array)
{
    Console.Write("Array is: ");

    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

}

int Count(int[] array, int evenNumber)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input  a number of elements: ");
int sizeN = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(sizeN);
ShowArray(myArray);
Console.WriteLine(Count(myArray, 1));
*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);

    return array;     
}

void ShowArray(int[] array)
{
    Console.Write("Array is: ");

    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
Console.WriteLine();
}

int SumEvenInd(int[] array, int sumevnum)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}


Console.Write("Input  a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input  a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input  a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int sum = SumEvenInd(myArray, 1);
Console.WriteLine($"Вот такая получилась сумма чисел на нечетких позициях: {sum} ");
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArray(double size)
{
    double[] array = new double[(int)size];

    for(int i = 0; i < size; i++)
        // array[i] = new Random().NextDouble();
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    return array;     
}

void ShowArray(double[] array)
{
    Console.Write("Array is: ");

    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
Console.WriteLine();
}


double SumD(double[] array)
{
double min = double.MaxValue;
double max = double.MinValue;
double sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i] > max)
            max = array[i];
    if ( array[i] < min)
            min = array[i];
    }
    return sum = sum + (max - max);
}

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateRandomArray(size);
ShowArray(array);
SumD(array);

Console.WriteLine($"Разница между максимальным и минимальным значением = {SumD(array)}");
*/

// Вроде так, а разница = 0 и как поправить не пойму?! 