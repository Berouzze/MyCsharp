/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
// Заполнение массива рандомными трехзначными числами
void FillByRand(int[] array)
{
    int size = array.Length;

    int index = 0;

    while (index < size)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число (в диапазоне от 0 до 10)
        array[index] = rnd.Next(100, 1000); ;
        index++;
    }
}
// Подсчет четных чисел
int EvenNumber(int[] array)
{
    int count = 0; // Количетсво четных чисел
    for (int cycle = 0; cycle < array.Length; cycle++)
    {
        if (array[cycle] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int sizeArray = GetNumber("Введите длину массива: ");
int[] array = GreateArray(sizeArray);
FillByRand(array);
int evenNumb = EvenNumber(array);
System.Console.WriteLine(evenNumb);