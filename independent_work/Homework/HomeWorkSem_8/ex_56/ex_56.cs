// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 0 строка


// Ввод числа
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Создание двухмерного массива 
int[,] GreateArray(int size, int size2)
{
    return new int[size, size2];
}
 int[] CreateSingleArray(int size)
    {
    return new int[size];
    }
// Заполнение массива рандомными  вещественными числами
void FillByRand(int[,] array)
{   
    for (int index = 0; index < array.GetLength(0); index++)
    {
        for (int index2 = 0; index2 < array.GetLength(1); index2++)
        {
            //Создание объекта для генерации чисел
            array[index, index2] = new Random().Next(-10, 11);
        }
    }
}
int  MinSumArrayStrings(int[,] array)
{
    int[] arr = CreateSingleArray(array.GetLength(0));
    for (int  u = 0; u < array.GetLength(0); u++)
    {   
        int sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum+= array[u,i];
            arr[u]=sum;
        }
    }
    int minSum = arr.Min();
    int minIndex = Array.IndexOf(arr, minSum);
    return minIndex;
}

// Печать массива
void PrintArray(int[,] array)
{
    for (int index = 0; index < array.GetLength(0); index++)
    {
        for (int index2 = 0; index2 < array.GetLength(1); index2++)
        {
            Console.Write($" {array[index, index2]} ");
        }
        Console.WriteLine();
    }
}



int sizeM = GetNumber("Задайте двумерный массив размером m на n, m: ");
int sizeN = GetNumber("n: ");
int[,] numbers = GreateArray(sizeM, sizeN);
FillByRand(numbers);
PrintArray(numbers);
Console.WriteLine();
int minIndex = MinSumArrayStrings(numbers);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex}");