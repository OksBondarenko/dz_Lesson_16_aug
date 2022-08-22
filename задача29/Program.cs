// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int size = new Random().Next(1, 11);
int[] numbers = new int[size];
FullArray(numbers);
PrintArray(numbers);

void FullArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

void PrintArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}