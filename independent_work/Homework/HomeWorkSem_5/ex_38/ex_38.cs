/* Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// Ввод размера массива
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double GetNumberDouble(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}
// Создание массива
double[] GreateArray(int size)
{
    return new double[size];
}
// Заполнение массива в ручную
void FillByUser(double[] array)
{
    int size = array.Length;

    int index = 0;

    while (index < size)
    {
        array[index] = GetNumberDouble("Введите " + index
         + " вещественный элемент: ");
        index++;
    }
}
double DifferenceOfNumber(double[] array)
{
    double min = array.Min();
    double max = array.Max();
    double difNumb = max - min;
    return difNumb;
}

int sizeArray = GetNumber("Введите длину массива: ");
double[] array = GreateArray(sizeArray);
FillByUser(array);
double difference = DifferenceOfNumber(array);
System.Console.WriteLine("Ответ: " + difference);