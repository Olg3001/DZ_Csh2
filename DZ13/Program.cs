// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5   78 -> третьей цифры нет

Console.WriteLine("Введите трехзначное или большее число: ");
int number;

while (!int.TryParse(Console.ReadLine()!, out number))
{
    Console.WriteLine("Некорректный ввод");
    Console.WriteLine("Введите трехзначное или большее число: ");
}

void PrintThirdDigit(int number)
{
    if (number > 99)
    {
        while (number > 999)
        {
            number = number / 10;
        }

        int result(int number)
        {
            int thirdDigit = number % 10; // у трехзначного числа
            return thirdDigit;
        }
        Console.WriteLine("Третья цифра введенного числа: " + result(number));
    }

    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
PrintThirdDigit(number);