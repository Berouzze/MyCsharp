// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите целые числа");
Console.WriteLine("Первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());
if (number_one > number_two) {
    Console.WriteLine("Число "+number_one+ " больше числа "+ number_two);
} else {
     Console.WriteLine("Число "+ number_two + " больше числа "+ number_one);
}