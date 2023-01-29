// Найти максимальное из трех чисел
Console.WriteLine("Введите 1-е число");
int numbera = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int numberb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3-е число");
int numberc = int.Parse(Console.ReadLine());
if (numbera<numberb) numbera = numberb;
if (numbera<numberc) numbera = numberc;
Console.WriteLine("Самое большое число " + numbera);