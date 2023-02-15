Console.WriteLine("Введите номер дня недели: ");

int number_one = Convert.ToInt32(Console.ReadLine());

switch (number_one) {
    case 1 : Console.WriteLine("Понедельник, рабочий день.");
    break;
    case 2 : Console.WriteLine("Вторник, рабочий день.");
    break;
    case 3 : Console.WriteLine("Среда, рабочий день.");
    break;
    case 4 : Console.WriteLine("Четверг, рабочий день.");
    break;
    case 5 : Console.WriteLine("Пятница, сокращенный рабочий день.");
    break;
    case 6 : Console.WriteLine("Суббота, выходной день.");
    break;
    case 7 : Console.WriteLine("Воскресенье, выходной день.");
    break;
    default : Console.WriteLine("Такого дня недели нет");
    break;
}
