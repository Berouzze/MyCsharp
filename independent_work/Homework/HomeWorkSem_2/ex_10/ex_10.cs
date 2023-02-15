/* Задача 10: Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает вторую цифру этого числа. */

Console.WriteLine("Введите целое трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int secondNumb = 0;

if (number > 99 && number < 1000 || number<-99 && number > -1000) 
{
     
     secondNumb = (number/10)%10;
    
    Console.Write(secondNumb);
} 
else 
{
    Console.WriteLine("Введите целое трехзначное число и попробуйте еще раз!");
}
