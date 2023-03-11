// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

    for (int index = 0; index < array.GetLength(0); index++)
    {
        for (int index2 = 0; index2 < array.GetLength(1); index2++)
        {
            //Создание объекта для генерации чисел
            array[index, index2] = new Random().Next(-100, 101);

        }

    }

}
//Печать массива  ---- для проверки
// void PrintArray(double[,] array)
// {
//     for (int index = 0; index < array.GetLength(0); index++)
//     {
//         for (int index2 = 0; index2 < array.GetLength(1); index2++)
//         {
//             Console.Write($" {array[index, index2]} ");
//         }
//          Console.WriteLine();
//     }
// }

void SearchArrayElements(double[,] array, int firstPos, int secondPos)
{
    if (firstPos < 0 || firstPos > array.GetLength(0) - 1 || secondPos < 0 || secondPos > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[firstPos, secondPos]);
    }
}
int sizeM = new Random().Next(1, 10);
int sizeN = new Random().Next(1, 10);
double[,] numbers = CreateArray(sizeM, sizeN);
int firstPosition = GetNumber("Номер строки: ");
int secondPosition = GetNumber("Номер столбца: ");
FillByRand(numbers);
// PrintArray(numbers);  //------ для проверки
SearchArrayElements(numbers, firstPosition, secondPosition);
