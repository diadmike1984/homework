// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}

ShowNums(500);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.WriteLine(A(3, 2));
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int M, int N)
        {
            if (M == 0) return (N * (N + 1)) / 2;
            else if (N == 0) return (M * (M + 1)) / 2;
            else if (M == N) return M;  
            else if (M < N) return N + SumNumbers(M, N - 1);
            else return N + SumNumbers(M, N + 1);
        }

Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result = {SumNumbers(M, N)}");
*/

// Thank you so much for your mentorship!!!