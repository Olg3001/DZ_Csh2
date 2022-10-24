// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 1 -> нет
// не прописан ввод других символов, кроме цифр, - не получается

Console.WriteLine("Определите, является ли день недели выходным.");
Console.WriteLine("Введите порядковое число дня недели от 1 до 7: ");
int WeekDay = int.Parse(Console.ReadLine()!);


if (CorrectNumber(WeekDay))
{

    if (IsWorkingDay(WeekDay))
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}

else
{
    Console.WriteLine("Некорректный ввод");
}

bool CorrectNumber(int WeekDay)
{
    return WeekDay > 0 && WeekDay < 8;
}

bool IsWorkingDay (int WeekDay)
{
    return WeekDay > 0 && WeekDay < 6;
}
