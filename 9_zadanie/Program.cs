// Удалить вторую цифру трёхзначного числа
int numbera = new Random().Next(100, 1000);
Console.WriteLine("Число: " + numbera);
string strNumber = numbera.ToString();
        char a = strNumber[strNumber.Length - 1];
        char b = strNumber[strNumber.Length - 3];
Console.WriteLine(b);
Console.Write(a);

// после 2-го семинара понял другое решение
int y = numbera%10;
int x = numbera/100;
Console.WriteLine("решение 2: " +x);
Console.Write(y);