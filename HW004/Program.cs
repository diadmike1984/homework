 // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 /*
 int numToPow(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return(result);
}



Console.Write("Input a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result is {numToPow(a, b)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNum(int number)
{
    if(number < 10)
        return number;
    int num = number % 10;
    int newn = number / 10;
    return num + SumNum(newn);
    
}

Console.Write("Input a number: ");
int sum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum index number {sum} is {SumNum(sum)}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 100);

    return array;     
}

void ShowArray(int[] array)
{
    Console.Write("Array is: ");

    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

}

Console.Write("Input  a number of elements: ");
int sizeN = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(sizeN);
ShowArray(myArray);
*/