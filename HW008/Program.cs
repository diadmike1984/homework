//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void Show2dArray(int[,] array)
{
    Console.Write("2d array is: ");
    Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();    
}

void OrderArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

Console.Write("Input a numbers of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of colums: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(r, c, min, max);
Show2dArray(myArray);
OrderArray(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void Show2dArray(int[,] array)
{
    Console.Write("2d array is: ");
    Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();    
}


void RowMinSum(int[,] array)
{
    int minrow = 0;
    int minsumrow = 0;
    int sumrow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minrow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumrow += array[i, j];
        if (sumrow < minrow)
        {
            minrow = sumrow;
            minsumrow = i;
        }
        sumrow = 0;
    }
    Console.WriteLine($"{minsumrow + 1} строка");
}

Console.Write("Input a numbers of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of colums: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(r, c, min, max);
Show2dArray(myArray);
RowMinSum(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void Show2dArray(int[,] array)
{
    Console.Write("2d array is: ");
    Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();    
}


void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,]resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum = firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.Write("Input a numbers of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of colums: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(r, c, min, max);
Show2dArray(myArray);

Console.Write("Input a numbers of rows for second matrix: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of colums for second matrix: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value for second matrix: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value for second matrix: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateRandom2dArray(r1, c1, min1, max1);
Show2dArray(myArray1);

Console.Write("Input a numbers of rows for result matrix: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of colums for result matrix: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value for result matrix: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value for result matrix: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = CreateRandom2dArray(r2, c2, min2, max2);
Show2dArray(resultMatrix);

MultiplyMatrix(myArray, myArray1, resultMatrix);
Show2dArray(resultMatrix);
*/

// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3dArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] array = new int[x, y, z];

    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
            for(int k = 0; k < z; k++)
            array[i,j,k] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void Show3dArray(int[,,] array)
{
    Console.Write("3d array is: ");
    Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            Console.Write(array[i, j, k] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();    
}

void CreateArray(int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
    }
  }
}



Console.Write("Input a numbers of x for 3D matrix: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of y for 3D matrix: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of z for 3D matrix: ");
int Z = Convert.ToInt32(Console.ReadLine());

Console.Write("min possible value for 3D matrix: ");
int min = new Random().Next(10, 10);
Console.Write("max possible value for 3D matrix: ");
int max = new Random().Next(10, 100-1);

int[,,] myArray = CreateRandom3dArray(X, Y, Z, min, max);
Show3dArray(myArray);
CreateArray(myArray);
*/