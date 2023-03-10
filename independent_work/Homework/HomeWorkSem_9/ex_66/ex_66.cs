// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120                M = 4; N = 8. -> 30

// Ввод текста
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Ищем числа в промежутке от M до N и складываем
void PrintSumNumbers(int numb, int secondNumb, int sum)
{

    if (numb < secondNumb) { System.Console.WriteLine("Введите натуральное числа"); return; }
    if (secondNumb <= 0) { secondNumb = 1; }
    sum += numb;
    if (numb == secondNumb)
    {
        Console.WriteLine($"Ответ: {sum} ");
        return;
    }

    PrintSumNumbers(numb - 1, secondNumb, sum);
}

int secondNumber = GetNumber("Введите число M: ");
int number = GetNumber("Введите число N: ");
int sum = 0;
PrintSumNumbers(number, secondNumber, sum);
