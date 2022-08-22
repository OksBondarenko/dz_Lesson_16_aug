//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(123 -> 6)

int SumDigit(int num)
{
    int sum = 0;
    for(; num > 0; num /= 10)
        sum += num % 10;
    return sum;
}

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

Console.Write(SumDigit(digit));