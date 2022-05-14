// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int ThirdDigit(int a)
{
    if (a < 100)
    {
        return -1;
    }
    else
    {
        return 3;
    }


}

int RandomNumber = new Random().Next(0, 100000);
Console.WriteLine($"{RandomNumber} -> {ThirdDigit(RandomNumber)}");