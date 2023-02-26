/* Задача 27: Напишите метод, который принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// 1. Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}
// 2. Ввод числа
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// 3. Размер массива

int NumberSize(int Number)
{

    string str = Convert.ToString(Number);
    int Numb = str.Length;
    return Numb;
}
// 4. Заполнение массива
void FillByUser(int[] array, int Number)
{
    string str = Convert.ToString(Number);
    for (int count = 0; count < array.Length;)
    {
        foreach (char numb in str)
        {

            array[count] = int.Parse(numb.ToString());
            count++;
        }
    }
}

// 4. Вычисление суммы чисел массива 
int SumNumber(int[] array)
{
    int sum = 0;
    for (int cycle = 0; cycle < array.Length; cycle++)
    {
        sum += array[cycle];

    }
    return sum;
}
int originalNumber = GetNumber("Введите целое положительно число: ");
int size = NumberSize(originalNumber);
int[] numbers = CreateArray(size);
FillByUser(numbers, originalNumber);
int sumNumber = SumNumber(numbers);
System.Console.WriteLine(sumNumber);
