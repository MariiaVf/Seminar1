// 9. Напишите программу, которая 
// выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // целочисленное деление - покажет нам 7
int secondDigit = number % 10; // остаток от деления на 10 - покажет нам 8

// теперь нужно сравнить эти числа и узнать какое больше

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");
