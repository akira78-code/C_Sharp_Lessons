// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

78 -> 8

12-> 2

85 -> 8*/
/*
int MaxDigit (int num)
{
int dec = num / 10;
int ed = num % 10;
if(dec > ed) return dec;
else return ed;
}
int num = new Random().Next(10,99 + 1);

int result = MaxDigit(num);
Console.WriteLine(num);
Console.WriteLine(result);
Console.WriteLine((num.ToString())[0]);*/

/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно*/
/*
bool crat (int num1, int num2)
{
 if (num1 % num2 == 0) return true;
 else return false; 
}
Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());роверяет, кратно ли
Console.WriteLine($"{num1}, {num2} -> {crat(num1,num2)}");*/
/*Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.() 1*/
/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 2*/

//1
/*
bool crat (int num)
{
 if (num % 23 == 0 && num % 7 == 0 ) return true;
 else return false;
}
Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {crat(num)}");*/


//2
/*
bool crat (int num1, int num2)
{
 if (num1 * num1 == num2 || num2 * num2 == num1) return true;
 else return false; 
}
Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num1}, {num2} -> {crat(num1,num2)}");*/
