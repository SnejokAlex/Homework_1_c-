// Найти третью цифру числа или сообщить, что её нет
int numbera = new Random().Next(0, 1000000);
Console.WriteLine("Число которое делим " + numbera);
if (numbera<100) Console.WriteLine("3-й цифры нет, число меньше трехзначного");
else 
{
    string strNumber = numbera.ToString();
        char a = strNumber[2];
        Console.WriteLine("3-я цифра " + a);
}
