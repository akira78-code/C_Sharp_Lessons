//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*int CountCifr (int num)
{
    int count = 0;
    while(num > 0)
    {
        num /=10;
        count++;
    }
    return count;
}
Console.WriteLine(CountCifr(36478439));*/

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] Array = new int [size];
    for (int i =0; i < size; i++)
    {
        Array[i] = new Random().Next(minValue, (maxValue+1));
    }
    return Array;
}

void PrintArray (int [] Array)
{
    foreach(int n in Array)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();
}

PrintArray(CreateRandomArray(10,0,1));
//int[] myArray = 
