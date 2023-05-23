//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*

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
}*/
/*
int PosNum (int[] arroy)
{
    int count = 0;
    for(int i = 0; i<arroy.Length; i++)
    {
        if(arroy[i]%2 == 0) count++;
    }
    return count;
}

int [] array = CreateRandomArray(3,100,1000);
PrintArray(array);
Console.Write(PosNum(array));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
/*int SumNechet (int[] arroy)
{
    int sum = 0;
    for(int i = 0; i<arroy.Length; i++)
    {
        if(arroy[i]%2 == 1) sum+=arroy[i];
    }
    return sum;
}
int [] array = CreateRandomArray(4,100,1000);
PrintArray(array);
Console.Write(SumNechet(array));*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
/*
double [] CreateVeshestvArray()
{
    Console.WriteLine("Введите размер массива : ");
    int size = Convert.ToInt32(Console.ReadLine());
    
    double[] array = new double [size];
    for(int i = 0; i<size;i++)
    {
        Console.WriteLine("Введите вещественное число : ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

double Min (double[] array)
{
    double minvalue = array[0];
    for(int i = 0; i<array.Length;i++)
    {
        for(int c = 0; c<array.Length;c++)
        {
            if(minvalue<array[c]);
            else minvalue = array[c];
        }
    }
    return minvalue;
}

double Max (double[] array)
{
    double maxvalue = array[0];
    for(int i = 0; i<array.Length;i++)
    {
        for(int c = 0; c<array.Length;c++)
        {
            if(maxvalue>array[c]);
            else maxvalue = array[c];
        }
    }
    return maxvalue;
}
double [] array = CreateVeshestvArray();
Console.WriteLine($"Минимальное число -> {Min(array)}");
Console.WriteLine($"Максимальное число -> {Max(array)}");
Console.WriteLine($"Разница между максимальным и минимальным -> {(Max(array)-Min(array))}");
*/
