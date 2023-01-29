// Показать вторую цифру трёхзначного числа
int numbera = new Random().Next(100, 1000);
Console.WriteLine("Число: " + numbera);
string strNumber = numbera.ToString();
        char a = strNumber[strNumber.Length - 2];
        Console.WriteLine("вторая цифра " + a);