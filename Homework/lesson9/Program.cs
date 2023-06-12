//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


/*void NumN(int num)
{
    if(num > 0)
    {
        Console.Write(num + " ");
        NumN(num-1);
    }
    
}


NumN(5);*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*int Sum(int m,int n)
{
    if(m<n)
    {
        m+=Sum(m+1,n);
    }
    return m;
    
}
Console.Write(Sum(1,15));*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*void Akkerman (int num1, int num2)
{
    int computing(int num1,int num2){
    int err = 1;
    if (num1 < 0 || num2 < 0) err = 0;
        if (num1 == 0) return num2 + 1;
        if (num2 == 0) return computing(num1 - 1, 1);
        if (err == 0000) return 0000;
        return computing(num1 - 1, computing(num1, num2 - 1));
    }
    if(computing(num1,num2)==0000){Console.WriteLine("Ошибка! Значения не должны быть отрицательными!");}
    else{Console.WriteLine(computing(num1,num2));}
}
Akkerman(2,3);*/
