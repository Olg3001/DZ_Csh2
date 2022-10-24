// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5   78 -> третьей цифры нет

Console.WriteLine("Введите трехзначное или большее число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    FindThirdDigit(number);
}

void FindThirdDigit(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }

    int result(int number)
    {
        int thirdDigit = number % 10; 
        return thirdDigit;
    }
    Console.WriteLine("Третья цифра введенного числа: " + result(number));
}
