// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1

// нужно условие на проверку трехзначности

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (100 > number || 1000 < number) 
{
    Console.Write("Введено не трехзначное число");
    number = Convert.ToInt32(Console.ReadLine());
}

int GetNumber(int number)
{
    int newNumber = number / 10 % 10;
    return newNumber;
}

int finishNumber = GetNumber(number);
Console.WriteLine($"Вторая цифра => {finishNumber}");