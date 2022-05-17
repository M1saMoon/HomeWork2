//Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти:");
string quarter = Console.ReadLine()??"0";
if (quarter == "1")
    Console.WriteLine("Координаты x < 0, y > 0 находятся в 1 четверти!");
else if (quarter == "2")
    Console.WriteLine("Координаты x < 0, y > 0 находятся в 2 четверти!");
else if (quarter == "3")
    Console.WriteLine("Координаты x < 0, y < 0 находятся в 3 четверти!");
else if (quarter == "4")
    Console.WriteLine("Координаты x > 0, y < 0 находятся в 4 четверти!");
else 
Console.WriteLine("Нет такой четверти");