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