/*
Задача 25: Напишите метод, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B. нельзя использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

// 1. Ввод числа
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int MyMathPow(int numbOne)
{
    int NumberTwo = GetNumber("Введите второе число :");
    int count = numbOne;
    for (int cycle = 1; cycle < NumberTwo; cycle++)
    {
        count = numbOne * count;
    }
    return count;
}
int Number = GetNumber("Введите первое число :");

int Mynumber = MyMathPow(Number);
System.Console.WriteLine(Mynumber);