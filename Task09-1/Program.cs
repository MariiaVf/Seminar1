// 9. Напишите программу, которая 
// выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// 78 -> 8 
// 12-> 2 
// 85 -> 8
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// Решение через метод, как через черный ящик  который будет возвращать нам целое число

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int num) // сам метод  num = number
{
    // тело метода. здесь мы реализуем алгоритм задачи

    int firstDigit = num / 10; // целочисленное деление - покажет нам 7
    int secondDigit = num % 10; // остаток от деления на 10 - покажет нам 8
    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}