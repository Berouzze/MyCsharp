/* Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет. */

Console.Write("Введи целове число: ");

int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber = 0;
int myNumber(int x)
{
    return (x / 100)%10;
}
if (number>99 || number<-99) 
{
    thirdNumber = myNumber(number);
    Console.Write(thirdNumber);
}
else 
{
    Console.Write("Третья цифра отсутствует");
}