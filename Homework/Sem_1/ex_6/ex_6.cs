// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)


Console.WriteLine("Введите целое число");

int number_one = Convert.ToInt32(Console.ReadLine());

if (number_one%2==0) {
    Console.WriteLine(number_one + " четное число.");
} else {
    Console.WriteLine(number_one +" нечетное число.");
}