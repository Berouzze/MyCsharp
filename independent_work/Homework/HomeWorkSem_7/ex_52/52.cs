// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Ввод числа
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Создание двухмерного int массива 
int[,] CreateArray(int size, int sizeTwo)
{
    return new int[size, sizeTwo];
}

// Заполнение массива рандомными целыми числами
void FillByRand(int[,] array)
{

    for (int index = 0; index < array.GetLength(0); index++)
    {
        for (int index2 = 0; index2 < array.GetLength(1); index2++)
        {
            //Создание объекта для генерации чисел
            array[index, index2] = new Random().Next(-5, 5);

        }

    }

}
void AAColumn(int[,] array)
{
    for (int index = 0; index < array.GetLength(1); index++)
    {
        double sum = 0;
        for (int index2 = 0; index2 < array.GetLength(0); index2++)
        {
            sum += array[index2, index];
        }
        Console.Write($" {sum / array.GetLength(0)}    ");
    }
}
int sizeM = GetNumber("Задайте двумерный массив размером m на n, m: ");
int sizeN = GetNumber("n: ");
int[,] numbers = CreateArray(sizeM, sizeN);
FillByRand(numbers);
AAColumn(numbers);