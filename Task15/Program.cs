// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

bool FreeDay(int number)
{
    return number == 6 || number == 7;
}

bool result = FreeDay(num);

if (result == true)
    Console.WriteLine($"{num} -> Да");
else
    Console.WriteLine($"{num} -> Нет");















// while (num < 1 || num > 7)
// {
//     Console.WriteLine("Этот день не является выходным");
//     num = Convert.ToInt32(Console.ReadLine());
// }