// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int numbera = new Random().Next(10, 100);
Console.WriteLine("Число: " + numbera);
string strNumber = numbera.ToString();
        char a = strNumber[strNumber.Length - 1];
        char b = strNumber[strNumber.Length - 2];
if (a>b) Console.WriteLine(a);
else Console.WriteLine(b);
