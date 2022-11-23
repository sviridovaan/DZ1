// напишите программу, которая принимает 3 числа и выдает максимальное (2;3;7) (44;5;78) (22;3;9)
// Программа работает при подстановке ряда чисел (2;3;7) (44;5;78) (22;3;9)
Console.Clear();
int numberA = 2;
int numberB = 3;
int numberC = 7;
if (numberB>numberA & numberB>numberC)
{
    Console.WriteLine($"Максимальное число равно {numberB}");
}
else
{
    if (numberC>numberA & numberC>numberB)
    {
        Console.WriteLine($"Максимальное число равно {numberC}");
    }
    else
    {
        Console.WriteLine($"Максимальное число равно {numberA}");
    }
}