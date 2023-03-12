// Задача 64: Задайте значение N. Напишите программу,которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int numb)
{
    if (numb < 0) { System.Console.WriteLine("Не натуральное число"); }
    if (numb == 0) { return; }
    Console.Write($"{numb} ");
    PrintNumbers(numb - 1);
}


int number = GetNumber("Введите число N: ");
PrintNumbers(number);