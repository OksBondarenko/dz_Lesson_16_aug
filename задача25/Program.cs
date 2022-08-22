// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for(; numB > 0; numB--)
        result *= numA;
    return result;
}    

int numberA = ReadInt("Введите первое число: ");
int numberB = ReadInt("Введите второе число: ");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Exponentiation(numberA, numberB));