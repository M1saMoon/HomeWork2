//По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine()??"0");
int b = int.Parse(Console.ReadLine()??"0");
if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом {b}!");
}
if (b == a * a)
{
    Console.WriteLine($"Число {b} является квадратом {a}!");
}
else{
    Console.WriteLine("Числа не являются квадратом друг друга!");
}