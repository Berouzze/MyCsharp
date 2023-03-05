/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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
        array[index] = GetNumber("Введите " + index
         + " целый элемент: ");
        index++;
    }
}

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

int sizeArray = GetNumber("Введите количество чисел: ");
int[] array = GreateArray(sizeArray);
FillByUser(array);
int evenNumb = EvenNumber(array);
System.Console.WriteLine(evenNumb);