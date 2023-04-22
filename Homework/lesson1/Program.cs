// Задача 1.
/*
Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2) Console.WriteLine($"Первое число - {num1} больше второго - {num2}");   
else Console.WriteLine("Второе число больше первого");*/

// Задача 2.
/*
Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число :");
int num3 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    if (num1 > num3) {Console.WriteLine($"Максимальное - первое введённое число  - {num1}");}
}
else
{
    if (num2 > num3){Console.WriteLine($"Максимальное - второе введённое число  - {num2}");}
    else {Console.WriteLine($"Максимальное - третье введённое число  - {num3}");}
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
if(num > 0) {
while(num != 0)
{
    if ((num % 2) == 0){Console.Write($"{num}, ");}
    num = num -1;
}
}
else {Console.WriteLine("Число должно быть большне 0");}*/