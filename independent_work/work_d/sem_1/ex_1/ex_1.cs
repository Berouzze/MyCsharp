// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите целое трехзначное число: ");

int number_one = Convert.ToInt32(Console.ReadLine());

number_one = (number_one/10)%10;

Console.WriteLine(number_one + " вторая цифра вашего числа.");