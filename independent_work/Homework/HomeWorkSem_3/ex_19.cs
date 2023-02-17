/*Задача 19 Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом. */

int GetNumber(string text)
{
 System.Console.WriteLine(text);
 return Convert.ToInt32(Console.ReadLine());
}


string PolidromFiveSize(int numb)
{
    if (numb< 100000 && numb> 9999)
    {
        int a = numb/10000;
        int b = (numb/1000)%10;
        int c = (numb/10)%10;
        int d = numb%10;
    
         if (a == d && b==c)
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
