// 26. Возведите число А в натуральную степень B используя цикл
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void Squaad(int a, int b)
{
    int c = a;
    while (b != 1)
    {
        a *= c;
        b--;
    }
    Console.WriteLine(a);
}

int secondNumber = GetNumber("Введите число a: ");
int number = GetNumber("Введите число b: ");
Squaad(secondNumber, number);