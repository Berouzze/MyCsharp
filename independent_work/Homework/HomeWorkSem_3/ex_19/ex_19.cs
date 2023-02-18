/*Задача 19 Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом. */

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


string PolidromFiveSize(int numb)
{
    if (numb < 100000 && numb > 9999 || numb > -100000 && numb < -9999)
    {
        int firstDigit = numb / 10000;
        int secondDigit = (numb / 1000) % 10;
        int thirdDigit = (numb / 10) % 10;
        int fourthDigit = numb % 10;

        if (firstDigit == fourthDigit && secondDigit == thirdDigit)
        {
            return "Введенное число " + numb + " палиндром";
        }
        else
        {
            return "Введенное число " + numb + " не палиндром";
        }
    }
    else
    {
        return "Введите пятизначное число и попробуйте еще раз.";
    }
}



int number = GetNumber("Введите число: ");
Console.WriteLine(PolidromFiveSize(number));
