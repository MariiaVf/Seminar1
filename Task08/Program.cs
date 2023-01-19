// Задача 8: 
// Напишите программу, которая 
// на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0)
{
    Console.WriteLine("Введено не натуральное число");
    number = Convert.ToInt32(Console.ReadLine());
}
int count = 2;
while (count <= number)
{
    Console.WriteLine($"{count} ");
    count +=2;
}
