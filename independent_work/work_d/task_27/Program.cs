// 27. Определить количество цифр в числе
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void ValueCount(int numb, int count)
{
    if ( numb < 10 &&  numb > -10) { Console.WriteLine(count+1); return; }
    int value = numb / 10;
    count++;
    ValueCount(value,count);

}

int number  = GetNumber("Your number: ");
int count2 = 0;
ValueCount(number, count2 );

