// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.        0,5 7 -2 -0,2       1 -3,3 8 -9,9       8 7,8 -7,1 9

Console.Clear();
// double[,] massiv = new double[3,4];
// Random rand = new Random();
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         massiv[i,j] = rand.NextDouble()*20-10;
//         Console.Write("{0,7:F1}", massiv[i,j]);
//     }
//     Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] massiv = new int[3,4];
// Random rand = new Random();
// int line = 0;
// int colomn = 0;
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         massiv[i,j] = rand.Next(0, 9);
//         Console.Write($"{massiv[i, j]}\t");
//         colomn++;
//     }
//     Console.WriteLine();
//     line++;
// }
// Console.WriteLine("Укажите строку массива: ");
// int line1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите столбец массива: ");
// int colomn1 = Convert.ToInt32(Console.ReadLine());
// if (line1 <= line && colomn1 <= colomn)
// {
//     Console.WriteLine($"Значение выбранного элемента: {massiv[line1-1,colomn1-1]}");
// }
// else
// {
//     Console.WriteLine("Указанный элемент отсутствует, превышен предел массива.");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] massiv = new int[3,4];
Random rand = new Random();
double line = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = rand.Next(1, 9);
        Console.Write($"{massiv[i, j]}\t");
    }
    Console.WriteLine();
    line++;
}
Console.Write("Среднее арифметическое в каждом столбце: ");
int sumsr = 0;
for (int j = 0; j < massiv.GetLength(1); j++)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sumsr = sumsr + massiv[i,j];
    }
    Console.Write("{0,7:F1}", sumsr / line );
    sumsr = 0;
}
