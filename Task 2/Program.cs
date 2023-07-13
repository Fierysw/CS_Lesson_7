// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

Console.Write("Введите размерность m массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность n массива: ");
int n = int.Parse(Console.ReadLine()!);
int[,] randomArray = new int[m, n];
Console.Write("Введите позицию строки: ");
int m2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию столбца: ");
int n2 = int.Parse(Console.ReadLine()!);
createRandomArray(randomArray);

void createRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}

if (m2 < 1 || n2 < 1)
  Console.Write("Позиции строк не могут быть отрицательными");
else if (m2 <= m + 1 && n2 <= n + 1)
  Console.Write($"Значение элемента равно {randomArray[m2 - 1, n2 - 1]} ");
else Console.Write("Такого элемента нет в массиве");