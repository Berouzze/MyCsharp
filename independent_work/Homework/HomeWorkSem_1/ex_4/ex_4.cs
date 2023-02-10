// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


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