/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19        [-4, -6, 89, 6] -> 0
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
// Заполнение массива рандомными числами
void FillByRand(int[] array)
{
    int size = array.Length;

    int index = 0;

    while (index < size)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        array[index] = rnd.Next(-100, 101);
        index++;
    }
}
// Подсчет суммы нечетных чисел
int SumNumber(int[] array)
{
    int sumArr = 0;
    for (int cycle = 0; cycle < array.Length; cycle++)
    {
        if (array[cycle] % 2 != 0)
        {
            sumArr += array[cycle];
        }
    }
    return sumArr;
}
int sizeArray = GetNumber("Введите длину массива: ");
int[] array = GreateArray(sizeArray);
FillByRand(array);
int sumNumb = SumNumber(array);
System.Console.WriteLine(sumNumb);

// Ограничил диапазон рандомных чисел от -100 до 101 для удобства