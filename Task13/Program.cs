// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет 
// 32679 -> 6

int randomNumber = new Random().Next(-1000000, 1000000);
Console.WriteLine($"Случайное число => {randomNumber}");
int posNumber = 0;
if (randomNumber < 0)
{
    posNumber = TrehNum(-randomNumber);
}
else 
{
    posNumber = TrehNum(randomNumber);
}

int TrehNum(int num)
{
    if (100 > num) return -1;
    while (num > 999)
    {
        num /= 10;
    }
    return num %10;
}
if (posNumber == -1) Console.WriteLine("Третьего числа нет");

Console.WriteLine($"Третья цифра => {posNumber}");
