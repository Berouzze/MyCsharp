Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x);
if (x % 7 == 0)
{
    x = x / 7;
    if (x % 23 == 0 && x% 7 == 0) 
    {
        Console.WriteLine("Число кратно 7 и 23");
    }
  
    else
    {
        Console.WriteLine("Число не кратно 7 и 23");
    }
}
