// Удалить вторую цифру трёхзначного числа
int numbera = new Random().Next(100, 1000);
Console.WriteLine("Число: " + numbera);
string strNumber = numbera.ToString();
        char a = strNumber[strNumber.Length - 1];
        char b = strNumber[strNumber.Length - 3];
Console.Write(b);
Console.Write(a);