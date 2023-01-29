// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите 1 число");
int numbera = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите 2 число");
int numberb = int.Parse(Console.ReadLine ());
numberb = numberb * numberb;
if (numbera==numberb) Console.WriteLine("1-е число - это квадрат 2-го числа");
else Console.WriteLine("1-е число НЕ является квадратом 2-го");
