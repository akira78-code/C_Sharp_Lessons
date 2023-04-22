/*Console.WriteLine("Введи цифру, сучара !");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ты ввёл {num} цифру");*/

//Task1. Запросить число и вывести его квадрат
/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Квадрат числа - {(num*num)}");*/

//Task2. Является ли первое число квадратом второго числа ?
/*Console.WriteLine("Введите 1 число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число : ");
int num2 = Convert.ToInt32(Console.ReadLine());
if((num2*num2) == num1)
{
  Console.WriteLine("Первое число - это квадрат второго.");  
}
else{Console.WriteLine("Первое число - не квадрат второго !");}*/

//Task3. Напищите программу которая принимает на вход число N, на выходе получаем последовательность от -N до N
/*Console.WriteLine("Введите N : ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<0){Console.WriteLine("Invalid input N");}
int count = n*(-1);
while(count <= n)
{
    Console.WriteLine(count+" ");
    count++;
}*/

//Task 4. На вход принимаем 3х значное число, вывести последнюю цифру данного числа.
/*
Console.WriteLine("Введите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int ed = n % 10;
Console.WriteLine($"Последняя цифра числа - {ed}");*/
int a = 1;
Console.WriteLine(a.GetType());
Console.ReadLine();