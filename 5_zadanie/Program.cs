//Показать четные числа от 1 до N
Console.WriteLine("Введите до какого числа выводить четные");
int numbera = int.Parse(Console.ReadLine());
int numberb = 2;
while (numberb<=numbera)
{
    Console.WriteLine(numberb);
    numberb = numberb+2;
}