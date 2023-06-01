//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Array2D (int row,int column)
{
    double[,] array = new double [row,column];
    for(int i =0; i<row;i++)
    {
        for(int c = 0; c < column; c++)
        {
            Random rnd = new Random();
            array[i,c] = rnd.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write(array[i,c]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
    Console.WriteLine("Введите количество строк : ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов : ");
    int column = Convert.ToInt32(Console.ReadLine());
    PrintArray(Array2D(row,column));

*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int[,] CreateRandom2DArray()
{
Random rnd = new Random();
int row = rnd.Next(1,11);
int column = rnd.Next(1,11);
int[,] array = new int [row,column];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        array[i,c] = rnd.Next(1,11);
    }
}
return array;
}

void PrintArray(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        Console.Write(array[i,c]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
};

void ProverkaPos(int[,] array)
{
Console.WriteLine("Введите позицию строки :");
int row_pos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца :");
int column_pos = Convert.ToInt32(Console.ReadLine());
if(row_pos > (array.GetLength(0)-1))Console.WriteLine("ХА-ХА! Не угадал!");
if(column_pos > (array.GetLength(1)-1))Console.WriteLine("ХА-ХА! Не угадал!");
else Console.WriteLine($"Элемент на заданной позиции - {array[row_pos,column_pos]}");}

int[,] array = CreateRandom2DArray();
ProverkaPos(array);
PrintArray(array);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void Print2DArray(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        Console.Write(array[i,c]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
};

void Print1DArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
        Console.Write(array[i]);
        Console.Write(" ");
    }
};

int[,] CreateRandom2DArray()
{
Random rnd = new Random();
int row = rnd.Next(1,11);
int column = rnd.Next(1,11);
int[,] array = new int [row,column];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        array[i,c] = rnd.Next(1,11);
    }
}
return array;
}
int[,] array = CreateRandom2DArray();
Print2DArray(array);
Console.WriteLine("---------------");

void SrArifm(int[,] array)
{
int temp = 0;
int count = 0;
double [] res = new double [array.GetLength(1)];
for(int i = 0; i < array.GetLength(1); i++)
{
    for(int c = 0; c < array.GetLength(0); c++)
    {
        temp+=array[c,i];
        count++;
    }
    res[i] = Math.Round(((double) temp/count),2);
}
Print1DArray(res);
}
SrArifm(array);*/