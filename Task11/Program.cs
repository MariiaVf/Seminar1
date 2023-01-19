// 11. Напишите программу, которая 
// выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.
//   456 -> 46 
//   782 -> 72 
//   918 -> 98

int rendomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {rendomNumber}");

int finishNumber = GetNumber(rendomNumber);
Console.WriteLine($"Конечное число => {finishNumber}");

int GetNumber(int number)
{
    int firstNumber = number / 100; // получим первое число
    int secondNumber = number % 10;

    int result = firstNumber * 10 + secondNumber;
    return result;
}


