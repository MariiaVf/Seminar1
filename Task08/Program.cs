// Задача 8: 
// Напишите программу, которая 
// на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else
{
    Console.WriteLine($"Число {number} не является четным");
}
