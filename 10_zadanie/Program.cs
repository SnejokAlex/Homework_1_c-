// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int numbera = new Random().Next(100, 1000);
Console.WriteLine("Число которое делим " + numbera);
int numberb = new Random().Next(1, 11);
Console.WriteLine("Число на которое делим " + numberb);
if (numbera%numberb==0) Console.WriteLine("Число кратно");
else Console.WriteLine(numbera%numberb);