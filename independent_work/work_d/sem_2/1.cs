Console.WriteLine("Введите целое трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
 int firstNumb = 0;
 int secondNumb = 0;
if (number > 99 && number < 1000) 
{
     firstNumb = number/100;
     secondNumb = number%10;
     Console.Write(firstNumb);
    Console.Write(secondNumb);
} else 
{
Console.WriteLine("Введите целое трехзначное число и попробуйте еще раз!");
}