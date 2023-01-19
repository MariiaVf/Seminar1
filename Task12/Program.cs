// 12. Напишите программу, которая будет 
// принимать на вход два числа 
// и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int MultipleNumber(int num1, int num2)
{
    return num1 % num2;
}

Console.WriteLine("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

int remains = MultipleNumber(numberFirst, numberSecond); // Вводим переменную 

if (remains == 0)
Console.WriteLine($"Кратно");
else
Console.WriteLine($"Не кратно, остаток {remains}");