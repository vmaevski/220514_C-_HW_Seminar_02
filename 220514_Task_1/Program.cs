// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

int SecondDigit(int number)
{
    return number % 100 / 10;
}

Console.WriteLine(SecondDigit(456));