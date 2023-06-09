Console.WriteLine("Введите номер дня недели. От 1 до 7");
int numberDay = int.Parse(Console.ReadLine());
Console.Write("Выбранный день: ");
if(numberDay == 1) Console.WriteLine("Понедельник");
else if (numberDay == 2) Console.WriteLine("Вторник");
else if(numberDay == 3) Console.WriteLine("Среда");
else if(numberDay == 4) Console.WriteLine("Четверг");
else if(numberDay == 5) Console.WriteLine("Пятница");
else if(numberDay == 6) Console.WriteLine("Суббота");
else if(numberDay == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Неверный выбор");

switch (numberDay){
    case 1:
        Console.WriteLine("Mondey");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
}