// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

 // Ограничил диапазон рандомных чисел от -100 до 101 для удобства

// Ввод числа
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Создание двухмерного массива 
double[,] CreateArray(int size, int size2)
{
    return new double[size, size2];
}

// Заполнение массива рандомными  вещественными числами
void FillByRand(double[,] array)
{
    
    for (int index = 0;index < array.GetLength(0); index++)
    {
        for  (int index2 = 0; index2 < array.GetLength(1); index2++)
        {
            //Создание объекта для генерации чисел
            array[index, index2] = new Random().Next(-100, 101);

        }
    
    }

}
// Печать массива
void PrintArray(double[,] array)
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
    double[,] numbers = CreateArray(sizeM, sizeN);
    FillByRandPrint(numbers);
    PrintArray(numbers);
   