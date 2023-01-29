// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня");
int numbera = int.Parse(Console.ReadLine ());
if (numbera==1) Console.WriteLine("Понедельник");
if (numbera==2) Console.WriteLine("Вторник");
if (numbera==3) Console.WriteLine("Среда");
if (numbera==4) Console.WriteLine("Четверг");
if (numbera==5) Console.WriteLine("Пятница");
if (numbera==6) Console.WriteLine("Суббота");
if (numbera==7) Console.WriteLine("Воскресенье");
if (numbera>7) Console.WriteLine("Ведите от 1 до 7");
if (numbera<=0) Console.WriteLine("Ведите от 1 до 7");