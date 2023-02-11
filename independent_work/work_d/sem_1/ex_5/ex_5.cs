// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите свое целое положительное число: ");

int number_one = Convert.ToInt32(Console.ReadLine());
int size = -(number_one);
while (size <= number_one) {
    Console.WriteLine(size);
    size++;
}