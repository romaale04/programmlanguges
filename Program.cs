// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: "); 
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()); 
if (a > b) 
{
    Console.WriteLine($"Число {a} - большее.");
}
else if (b > a)
{
    Console.WriteLine($"Число {b} - большее.");
}
else if (a == b)
{
    Console.WriteLine($"Числа равны ");
} 