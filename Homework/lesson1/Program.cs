// Задача 1.
/*
Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2) Console.WriteLine($"Первое число больше второго :  {num1} > {num2}");   
else Console.WriteLine($"Второе число больше первого : {num2} > {num1}");*/

// Задача 2.
/*
Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число :");
int num3 = Convert.ToInt32(Console.ReadLine());
//int max;
if (num1 > num2) {if (num1 > num3) {Console.WriteLine($"Максимальное - первое введённое число  - {num1}");}}

if (num2 > num1) {if (num2 > num3) {Console.WriteLine($"Максимальное - второе введённое число  - {num2}");}}

if (num3 > num1) {if (num3 > num2) {Console.WriteLine($"Максимальное - третье введённое число  - {num3}");}}

if (num1 == num2 && num2 == num3) {Console.WriteLine($"Введены одинаковые числа  - {num1}, {num2}, {num3}");}

if (num1 == num2)
{
    if (num2 > num3){Console.WriteLine($"Введены два одинаковых числа. Максимальное - {num2}");}
    else {Console.WriteLine($"Введены два одинаковых числа. Максимальное - {num3}");}
}
if (num2 == num3)
{
    if (num2 > num1){Console.WriteLine($"Введены два одинаковых числа. Максимальное - {num2}");}
    else {Console.WriteLine($"Введены два одинаковых числа. Максимальное - {num1}");}
}
if (num1 == num3)
{
    if (num1 > num3){Console.WriteLine($"Введены два одинаковых числа. Максимальное - {num1}");}
    else {Console.WriteLine($"Введены два одинаковых числа. Максимальное - {num3}");}
}
*/

// Задача 3.
/*
Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 2) == 0) {Console.WriteLine("Число чётное.");}
else{Console.WriteLine("Число нечётное.");}
*/

// Задача 4.

/*
Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int i_num;
if ((num % 2) == 0) {i_num = num;}
else
{
    num = num - 1;
    i_num = num;
}
if(num > 0) {
while(num != 0)
{
    if ((num % 2) == 0){Console.Write($"{i_num - (num - 2)}, ");}
    num = num -1;
}
}
else {Console.WriteLine("Число должно быть большне 0");}
*/