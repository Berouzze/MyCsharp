/* Задача 10: Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает вторую цифру этого числа. */

Console.WriteLine("Введите целое трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int secondNumb = 0;
int myNumber(int y)
{
return (y/10)%10;
}
if (number > 99 && number < 1000 || number<-99 && number > -1000) 
{
     
     secondNumb = myNumber(number);
    
    Console.Write(secondNumb);
} 
else 
{
    Console.WriteLine("Введите целое трехзначное число и попробуйте еще раз!");
}
