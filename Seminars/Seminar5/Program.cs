//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.


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

//PrintArray(CreateRandomArray(10,0,1));
//int[] myArray = 
/*void PosNegSum(int [] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0) sumPos+= array[i];
        else sumNeg+= array[i];
    }
    Console.WriteLine($"Sum of positive elements -> {sumPos}, sum of negative elements -> {sumNeg}");
}
int [] Array = CreateRandomArray(12,-9,9);
//PrintArray(PosNegSum(Array)); */

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]
/*int[] InvertArray(int [] array)
{
    for (int i =0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
*/
//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

int [] CreateArray (int size)
{
    int [] array = new int [size];
    for (int i =0; i < size; i++)
    {
        Console.Write($"Введите число элемента массива {i} ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool NumFind(int num, int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}


//if (NumFind(4,CreateArray(5))) Console.WriteLine($"Число есть {4}");
//else Console.Write("Числа нет");
/*int NumFind2(int[] array)
{
    int count = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if(array[i] <= 99 && array[i] > 10) count++;
    }
    return count;
}
 
 int [] myArray =  CreateRandomArray(12,1,150);

 PrintArray(myArray);
 Console.WriteLine(NumFind2(myArray));*/
