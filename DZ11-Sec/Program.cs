// 1 программист, 2 программиста, 5 программистов
// TwoLastDigits для чисел 11-14

Console.WriteLine("Введите число программистов в комнате: ");
int NumberOfProgrammists = int.Parse(Console.ReadLine()!);

int LastDigit = NumberOfProgrammists % 10;
int TwoLastDigits = NumberOfProgrammists % 100;

void ChooseLastDigits(int NumberOfProgrammists, int LastDigit)
{
    if (TwoLastDigits > 10 && TwoLastDigits < 15)
    {
        Console.WriteLine(NumberOfProgrammists + " програмистов");
    }

    else
    {
        if (LastDigit == 1)
        {
            Console.WriteLine(NumberOfProgrammists + " программист");
        }
        if (LastDigit > 1 && LastDigit < 5)
        {
            Console.WriteLine(NumberOfProgrammists + " программиста");
        }
        if (LastDigit > 4 || LastDigit == 0)
        {
            Console.WriteLine(NumberOfProgrammists + " программистов");
        }
    }
}

ChooseLastDigits(NumberOfProgrammists, LastDigit);
