//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2DArray()
{
Random rnd = new Random();
int row = rnd.Next(1,11);;
int column = rnd.Next(1,11);;
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

int[,] SortRowValue(int[,] array)
{
   
    for(int c = 0;c<array.GetLength(1);c++){
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0;j+1 < array.GetLength(1); j++)
        {
            if(array[i,j] < array[i,j+1])
            {
                int temp = array[i,j];
                array[i,j] = array[i,j+1];
                array[i,j+1] = temp;
            }
        }
    }}
return array;
}
int [,] array = CreateRandom2DArray();
Print2DArray(array);
Console.WriteLine("--------------------------");
int[,] arrayp = SortRowValue(array);
Console.WriteLine("массив после изменения");
Print2DArray(arrayp);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2DArray()
{
Random rnd = new Random();
int row = rnd.Next(3,5);;
int column = rnd.Next(5,10);;
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

void Print1DArray(int[] array)
{
    Console.WriteLine("Массив с суммами : ");
    foreach(int i in array)
    {
        Console.Write(i);
        Console.Write(" ");
    }
}

void MinSumRow(int[,] array)
{
    int sum=0;
    int[] sum_array = new int [array.GetLength(0)];
    for(int i =0;i<array.GetLength(0);i++)
    {
        for(int j = 0;j<array.GetLength(1);j++)
        {
            sum+=array[i,j];
        }
    sum_array[i] = sum;
    sum=0;
    }
    Print1DArray(sum_array);
    int min = sum_array[0];
    int index_row = 0;
for(int k =0;k<sum_array.Length;k++)
    {
        
        if(min>sum_array[k])
        {min=sum_array[k];
        index_row = k;
        }
    }
    Console.WriteLine($"\n Минимальная сумма элементов -> {min}, в строке {index_row}");
}

int[,] array = CreateRandom2DArray();
Print2DArray(array);
MinSumRow(array);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2DArray1()
{
Random rnd = new Random();
int row = 5;
int column = 5;
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
int[,] CreateRandom2DArray2()
{
Random rnd = new Random();
int row = 5;
int column = 5;
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

void Proizvedenie(int[,] array1, int[,] array2)
{   if(array1.GetLength(0) == array2.GetLength(1)){
    int sum = 0;
    int[,] result = new int[array1.GetLength(0),array2.GetLength(1)];
    for(int v = 0; v<array1.GetLength(0);v++)
    {
        for(int i = 0; i<array1.GetLength(0);i++)
        {
            for(int j = 0; j<array1.GetLength(1);j++)
            {
                sum+=array1[i,j]*array2[j,v];
            }
            result[i,v] = sum;
            sum=0;

        }
    }
    Print2DArray(result);}
    else{Console.WriteLine("Матрицы не согласованы, умножение не возможно.");}
}

int[,] array1 = CreateRandom2DArray1();
int[,] array2 = CreateRandom2DArray2();
Console.WriteLine("array1");
Print2DArray(array1);
Console.WriteLine("array2");
Print2DArray(array2);
Console.WriteLine("result");
Proizvedenie(array1,array2);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
/*
int[,,] CreateRandom3DArray()
{
Random rnd = new Random();
int row = 2;
int column = 2;
int d3d = 2;

int[,,] array = new int [row,column,d3d];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        for(int j = 0; j < array.GetLength(2); j++)
    {
        int val = rnd.Next(10,100);
        while(Proverka(array,val))
        {
            val = rnd.Next(10,100);
        }
        array[i,c,j] = val;
    }
    }
    
}
return array;
}
void Print3DArray(int[,,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        for(int j = 0; j < array.GetLength(2); j++)
    {
        Console.Write($"{array[i,c,j]} [{i},{c},{j}]");
        Console.Write(" ");
    }
    Console.WriteLine();
    }
}
};
bool Proverka(int[,,] array,int num)

{
    int count_exist = 0;
    for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        for(int j = 0; j < array.GetLength(2); j++)
    {
        if(array[i,c,j] == num) count_exist++;
        
    }
    
    }
}
if(count_exist > 0) return true;
else return false;
}
Print3DArray(CreateRandom3DArray());*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

//В ТЗ не описан спосбо создания и нет ни слова про универсальность. Всё предельно чётко.
/*
int[,] Create2DArray()
{
int row = 4;
int column = 4;
int[,] array = new int [row,column];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int c = 0; c < array.GetLength(1); c++)
    {
        array[i,c] = 0;
    }
}
return array;
}
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

int[,] Zapolnit(int[,] array)
{
    if(array.GetLength(0)== 4 && array.GetLength(1)== 4)
    {
    Random rnd = new Random();
    array[0,0] = rnd.Next(10,100);
    array[0,1] = rnd.Next(10,100);
    array[0,2] = rnd.Next(10,100);
    array[0,3] = rnd.Next(10,100);
    array[1,3] = rnd.Next(10,100);
    array[2,3] = rnd.Next(10,100);
    array[3,3] = rnd.Next(10,100);
    array[3,2] = rnd.Next(10,100);
    array[3,1] = rnd.Next(10,100);
    array[3,0] = rnd.Next(10,100);
    array[2,0] = rnd.Next(10,100);
    array[1,0] = rnd.Next(10,100);
    array[1,1] = rnd.Next(10,100);
    array[1,2] = rnd.Next(10,100);
    array[2,2] = rnd.Next(10,100);
    array[2,2] = rnd.Next(10,100);
    array[2,1] = rnd.Next(10,100);
    }
    return array;
}
Console.WriteLine("Создан массив 4x4 :");
int[,] array = Create2DArray();
Print2DArray(array);
Console.WriteLine("Массив заполнен спиарльно :");
Print2DArray(Zapolnit(array));*/