// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// пока что не удалось прописать ввод не цифр
// прописан вариант, если трехзначное число отрицательное


Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (rightNumber(number))
{
    int result(int number)
    {
        int secondDigit = number / 10 % 10;
        if (secondDigit < 0)
        {
            secondDigit = secondDigit * -1;
        }
        return (secondDigit);
    }
    Console.WriteLine("Вторая цифра вашего числа: " + result(number));
}
else
{
    Console.WriteLine("Неверный ввод");
}

bool rightNumber(int number)
{
    return 99 < number && number < 1000 || -99 > number && number > -1000;
}
