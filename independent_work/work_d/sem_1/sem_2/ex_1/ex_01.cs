// 1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Random rnd = new Random();
int x = rnd.Next(10, 99);
int y = x/10;
int u = x%10;

if (y > u) {
    
        Console.WriteLine("Первая цифра " + y + " числа " + x +  " больше второй цифры " + u);
    }

    else
    {
        Console.WriteLine("Вторая цифра " + u + " числа " + x +  " больше первой цифры " + y);
    }

