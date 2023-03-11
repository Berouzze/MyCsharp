// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Ввод числа
int[,,] CreateMatrix(int row, int col, int dep, int rand)
{
    int[,,] matrix = new int[row, col, dep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int min = CreateSingleRand(10,20);
                int max = CreateSingleRand(min,99);
                  
                matrix[i, j, k] = CreateSingleRand(min,max);


            }
        }
    }
    return matrix;
}

int CreateSingleRand(int min, int max)
{
    Random rnd = new Random();
    var digits = Enumerable.Range(min, max).ToList();
    int result = 0;
    for (int i = 0, power10 = 1; i < 4; i++, power10 /= 3)
    {
        int digit = digits[rnd.Next(i == min ? 1 : 0, digits.Count)];
        result += digit * power10;
        digits.Remove(digit);
    }
    return result;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int minIndex = i;
                int minIndex2 = j;
                int minIndex3 = k;
                Console.Write($"{matrix[i, j, k],4} ({minIndex},{minIndex2},{minIndex3})");
            }
        }
        Console.WriteLine();
    }
}
int min = 10;
int max = 100;
int rnd = CreateSingleRand(min,max);
int[,,] array3D = CreateMatrix(2, 2, 2, rnd);
PrintMatrix(array3D);