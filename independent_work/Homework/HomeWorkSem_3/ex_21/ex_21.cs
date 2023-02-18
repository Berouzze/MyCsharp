/* 
Задача 21 Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве. 
*/
// Ввод числа
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Ввод координат
void Coordinates(int[] array, int[] array2)
{   
    int lengthArray = array.Length+array2.Length;
    for (int count = 0, secondCount = 0, countDown = 3; count < lengthArray;)
    {
        if (count < countDown)
        {
            foreach (char readСoordinate in "XYZ")
            {
                array[count] = GetNumber("Введите координату " + readСoordinate + " первой точки: ");
                count++;
            }
        }
        else
        {
            foreach (char readСoordinate in "XYZ")
            {
                array2[secondCount] = GetNumber("Введите координату " + readСoordinate + " второй точки: ");
                count++;
                secondCount++;
            }
        }
    }
}
// Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}
// Вычисление расстояния
double Distance(int[] array, int[] array2)
{
    double cordinatsDistans = Math.Sqrt(Math.Pow((array2[0] - array[0]), 2) + Math.Pow((array2[1] - array[1]), 2) +
    Math.Pow((array2[2] - array[2]), 2));
    return cordinatsDistans;
}
int size = 3;
int[] numbers = CreateArray(size);
int[] numbers2 = CreateArray(size);
Coordinates(numbers, numbers2);
double distans = Distance(numbers, numbers2);
System.Console.WriteLine(distans);
