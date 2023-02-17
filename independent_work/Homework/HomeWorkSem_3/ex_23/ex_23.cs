// Задача 23 
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

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
// 3. Заполнянем массив кубами чисел
void FillByUser(int[] array)
{
    int size = array.Length;
    
    for  (int x = 0; x < size; x++)
    {
        
        array[x] =  Convert.ToInt32(Math.Pow(Convert.ToDouble(x),3));  
    }
}

// 4. Печать массива
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

int size = GetNumber("Введите число: ");
if (size > 0)  // Проверяем на условие от 1 до N
{
    int[] numbers = CreateArray(size);
    FillByUser(numbers);
    System.Console.WriteLine(Print(numbers));
}
else
{
    System.Console.WriteLine("Введите целое положительное число, не являющееся нулем и попробуйте еще раз");
}