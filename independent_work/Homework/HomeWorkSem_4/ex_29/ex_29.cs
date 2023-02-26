/* Задача 29: Напишите метод, который задаёт 
массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// Ввод размера массива
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Создание массива
int[] GreateArray(int size)
{
    return new int[size];
}
// Заполнение массива в ручную
void FillByUser(int[] array)
{
    int size = array.Length;

    int index = 0;

    while (index < size)
    {
        array[index] = GetNumber("Введите " + index + " элемент: ");
        index++;
    }
}
// Печать массива
string Print(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index]; 
        index++;
    }
    return result;
}
int sizeArray = GetNumber("Введите длину массива: ");
int[] array = GreateArray(sizeArray);
FillByUser(array);
System.Console.WriteLine(Print(array));