﻿// *Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void AckermanFunction (int m, int n)
{
    Console.Write ($"Ответ: {Ackermann (m, n)}"); 
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int number = GetNumber("Введите число m: ");
int secondNumber = GetNumber("Введите число n: ");
AckermanFunction(number, secondNumber);

