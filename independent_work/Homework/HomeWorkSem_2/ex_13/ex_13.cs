/* Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет. */

Console.Write("Введи целове число: ");

int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber = 0;

if (number>99 || number<-99) 
{
    thirdNumber = (number / 100)%10;
    Console.Write(thirdNumber);
}
else 
{
    Console.Write("Третья цифра отсутствует");
}