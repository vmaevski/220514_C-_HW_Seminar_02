// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Решено двумя способами:
int ThirdDigit_1(int a)
{
    if (a < 100)
    {
        return -1;
        // Функция возвращает -1, если в числе нет третьей цифры.
    }
    else
    {
        while (a >= 1000)
        {
            a /= 10;
        }
        return a % 10;
    }
}

int ThirdDigit_2(int a)
{
    if (a < 100)
    {
        return -1;
        // Функция возвращает -1, если в числе нет третьей цифры.
    }
    else
    {
        string str = a.ToString();
        // string str = Convert.ToString(a); // тоже работает
        // return str[2]; // не получается, что-то не так.

        // str = str.Substring(2); // Обрезаем первые два символа строки
        // str = str.Substring(0, 1); // Обрезаем, оставляя 1 первый символ строки
        str = str.Substring(2, 1); // Обрезаем, сразу оставляя только 3-й символ строки
        // return str; // Ошибка: Не удается неявно преобразовать тип "string" в "int"
        a = int.Parse(str); // Приходится переводить обратно в число
        return a;
    }
}


int RandomNumber = new Random().Next(0, 100000000);
if (RandomNumber < 100)
{
    Console.WriteLine($"There is no third digit in the number {RandomNumber}");
}
else
{
    Console.WriteLine($"Первый способ: {RandomNumber} -> {ThirdDigit_1(RandomNumber)}");
    Console.WriteLine($"Второй способ: {RandomNumber} -> {ThirdDigit_2(RandomNumber)}");
}

