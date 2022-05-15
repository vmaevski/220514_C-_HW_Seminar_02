// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// Будем считать, что суббота - день с номером 6, воскресенье - 7.

// int DayOff(int a)
void DayOff(int a) 
{
    if (a == 6 | a == 7)
    {
        // return ("YES!!!"); // не возвращает строку
        Console.WriteLine($"{a} -> YES!!!");
    }
    else
    {
        // return ("No("); // не возвращает строку
        Console.WriteLine($"{a} -> No(");
    }
}

int RandomNumber = new Random().Next(1, 8);
DayOff(RandomNumber);
// Console.WriteLine($"{RandomNumber} -> {DayOff(RandomNumber)}");