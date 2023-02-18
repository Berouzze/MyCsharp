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
    for (int x = 0, y = 0; x < 6;)
    {
        if (x < 3)
        {
            foreach (char c in "XYZ")
            {
                array[x] = GetNumber("Введите координату " + c + " первой точки: ");
                x++;
            }
        }
        else
        {
            foreach (char c in "XYZ")
            {
                array2[y] = GetNumber("Введите координату " + c + " второй точки: ");
                x++;
                y++;
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
    double I = Math.Sqrt(Math.Pow(Convert.ToDouble(array2[0] - array[0]), 2) + Math.Pow(Convert.ToDouble(array2[1] - array[1]), 2) +
    Math.Pow(Convert.ToDouble(array2[2] - array[2]), 2));
    return I;
}
int size = 3;
int[] numbers = CreateArray(size);
int[] numbers2 = CreateArray(size);
Coordinates(numbers, numbers2);
double distans = Distance(numbers, numbers2);
System.Console.WriteLine(distans);
