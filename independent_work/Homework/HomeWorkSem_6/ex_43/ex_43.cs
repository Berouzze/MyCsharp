/*  Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// Ввод числа
double GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}
// Ввод координат
void Coordinates(double[] array, double[] array2)
{   
    int lengthArray = array.Length+array2.Length;
    for (int count = 0, secondCount = 0, countDown = array.Length; count < lengthArray;)
    {
        if (count < countDown)
        {
            foreach (char readСoordinate in "XY")
            {
                array[count] = GetNumber("Введите координату " + readСoordinate + " первой точки: ");
                count++;
            }
        }
        else
        {
            foreach (char readСoordinate in "XY")
            {
                array2[secondCount] = GetNumber("Введите координату " + readСoordinate + " второй точки: ");
                count++;
                secondCount++;
            }
        }
    }
}
// Создание массива
double[] CreateArray(int size)
{
    return new double[size];
}
// Вычисление расстояния
string  Distance(double[] array, double[] array2)
{
    double x = -(array[0]-array2[0])/(array[1]-array2[1]);
    double y = (array[1] * x) + array[0];
    string text = ($"Пересечение в точке: ({x};{y})");
    return text;
}
int size = 2;
double[] numbers = CreateArray(size);
double[] numbers2 = CreateArray(size);
Coordinates(numbers, numbers2);
string distans = Distance(numbers, numbers2);
System.Console.WriteLine(distans);
