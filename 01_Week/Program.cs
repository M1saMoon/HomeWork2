//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Ввести день недели:");
int daynumber = int.Parse(Console.ReadLine()??"0");
if (daynumber == 6 || daynumber == 7 )
   Console.WriteLine("Веденный день недели является выходным днем!");
else 
   Console.WriteLine("Введенный день недели не является выходным днем!");


