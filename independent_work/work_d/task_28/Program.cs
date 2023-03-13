// 28. Подсчитать сумму цифр в числе
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void ValueCount(int numb, int count, int x)
{   
    
    if ( numb < 10 &&  numb > -10) { Console.WriteLine(count+ x); return; }
    int value = numb / 10;
    count +=  value % 10;
    ValueCount(value,count, x);
}

int number  = GetNumber("Your number: ");
int count2 = 0;
int num = number % 10;
ValueCount(number, count2, num );

