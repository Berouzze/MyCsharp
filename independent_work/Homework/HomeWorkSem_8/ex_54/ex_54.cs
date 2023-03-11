// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:     В итоге получается вот такой массив:
// 7 4 2 1                     1 4 7 2
// 9 5 3 2                     5 9 2 3
// 8 4 4 2                     8 4 2 4

// Ввод числа
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Создание двухмерного массива 
int[,] CreateArray(int size, int size2)
{
    return new int[size, size2];
}

// Заполнение массива рандомными  вещественными числами
void FillByRand(int[,] array)
{

    for (int index = 0; index < array.GetLength(0); index++)
    {
        for (int index2 = 0; index2 < array.GetLength(1); index2++)
        {
            //Создание объекта для генерации чисел
            array[index, index2] = new Random().Next(-100, 101);

        }

    }
}
// Сортировка строк массива
void SortArray(int[,] arr)
{
    
    for (int h = 0; h < arr.GetLength(0);h++)
    {   
        int n = arr.GetLength(1);
        for (int i = 0; i < arr.GetLength(1) - 1; i++)

        {
            int imax = 0;

            for (int j = 0; j < n; j++) if (arr[h,j] < arr[h,imax]) imax = j;

            int c = arr[h,imax];

            arr[h,imax] = arr[h,n - 1];

            arr[h,n - 1] = c;
            
            n--;

        }
    }
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
int[,] numbers = CreateArray(sizeM, sizeN);
FillByRand(numbers);
PrintArray(numbers);
Console.WriteLine();
SortArray(numbers);
PrintArray(numbers);



