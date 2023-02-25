public class Library
{


    public static int GetNumber(string text)
    {
        System.Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static string PolidromFiveSize(int numb)
    {
        if (numb < 100000 && numb > 9999 || numb > -100000 && numb < -9999)
        {
            int firstDigit = numb / 10000;
            int secondDigit = (numb / 1000) % 10;
            int thirdDigit = (numb / 10) % 10;
            int fourthDigit = numb % 10;

            if (firstDigit == fourthDigit && secondDigit == thirdDigit)
            {
                return "Введенное число " + numb + " палиндром";
            }
            else
            {
                return "Введенное число " + numb + " не палиндром";
            }
        }
        else
        {
            return "Введите пятизначное число и попробуйте еще раз.";
        }
    }
    // Ввод координат
    public static void Coordinates(int[] array, int[] array2)
    {
        int lengthArray = array.Length + array2.Length;
        for (int count = 0, secondCount = 0, countDown = array.Length; count < lengthArray;)
        {
            if (count < countDown)
            {
                foreach (char readСoordinate in "XYZ")
                {
                    array[count] = GetNumber("Введите координату " + readСoordinate + " первой точки: ");
                    count++;
                }
            }
            else
            {
                foreach (char readСoordinate in "XYZ")
                {
                    array2[secondCount] = GetNumber("Введите координату " + readСoordinate + " второй точки: ");
                    count++;
                    secondCount++;
                }
            }
        }
    }
    // Создание массива
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }
    // Вычисление расстояния
    public static double Distance(int[] array, int[] array2)
    {
        double cordinatsDistans = Math.Sqrt(Math.Pow((array2[0] - array[0]), 2) + Math.Pow((array2[1] - array[1]), 2) +
        Math.Pow((array2[2] - array[2]), 2));
        return cordinatsDistans;
    }
    // 3. Заполнянем массив кубами чисел
    public static void FillByUser(int[] array)
    {
        int size = array.Length;

        for (int index = 0, value = 1; index < size; index++, value++)
        {

            array[index] = (int)(Math.Pow(value, 3));

        }
        
    }

    // 4. Печать массива
    public static string Print(int[] array)
    {
        string result = String.Empty;
        int len = array.Length;
        int index = 0;
        while (index < len)
        {
            result += " " + array[index];
            index++;
        }
        return result;
    }


}