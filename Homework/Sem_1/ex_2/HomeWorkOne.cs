// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* Console.WriteLine("Введите целые числа");
Console.WriteLine("Первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());
if (number_one > number_two) {
    Console.WriteLine("Число "+number_one+ " больше числа "+ number_two);
} else {
     Console.WriteLine("Число "+ number_two + " больше числа "+ number_one);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите три целых числа");
int cycle = 3;
int size = 0;
int maxNumber = 0;
while (size<cycle) {
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers> maxNumber) {
    maxNumber = numbers;
} 
size++;
}
Console.WriteLine("Максимальное число " + maxNumber);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*
Console.WriteLine("Введите целое число");

int number_one = Convert.ToInt32(Console.ReadLine());

if (number_one%2==0) {
    Console.WriteLine(number_one + " четное число.");
} else {
    Console.WriteLine(number_one +" нечетное число.");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите целое число");

int number_one = Convert.ToInt32(Console.ReadLine());
int size = 1;

while (size <= number_one) {    // вывод числа  включая number_one
   if (size%2==0) { 
    Console.WriteLine(size); 
}
size++;
}