// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

int DelSecDigit(int a)
{
    return a / 100 * 10 + a % 10;
}

int RandomNumber = new Random().Next(100, 1000);
Console.WriteLine($"{RandomNumber} -> {DelSecDigit(RandomNumber)}");