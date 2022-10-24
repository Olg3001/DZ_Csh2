// Напишите программу, которая принимает на вход целое число 
// любой разрядности число и удаляет вторую цифру слева направо этого

Console.WriteLine("В этой программе во введенном числе можно удалить вторую цифру слева");
Console.Write("Введите число: ");
int numA = int.Parse(Console.ReadLine()!);

if (numA < 9)
    {
        Console.WriteLine("Второй цифры нет");
    }
else 
{
int numB = 0;
int numC = 0;
int numP = 1;

int NumberAfterDelSecDigit(int numA)
{
    int numResult = numA;
    if (numA > 99)
    {
        while (numA > 99)
        {
            numB = numA % 10;
            numA = numA / 10;
            numC = numC + numB * numP;
            numP = numP * 10;
        }
        numA = numA / 10;
        numResult = numP * numA + numC;
    }
    if(numA < 100 && numA > 9)
    {
        numResult = numA / 10;
    }
    return numResult;
}        

int numResult = NumberAfterDelSecDigit(numA);
Console.WriteLine("Число после удаления второй цифры: " + numResult);
}