//Задание1.  Напишите программу, которая принимает на вход координаты точки 
//(X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart ()
{
Console.WriteLine("Введите координаты X :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y :");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) {return 1;}
if (x < 0 && y > 0) {return 2;}
if (x < 0 && y < 0) {return 3;}
if (x > 0 && y < 0) {return 4;}
return 0;
}
int result = FindQuart();
Console.WriteLine(result);*/

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
/*

double FindDistance (double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)),2);
}
Console.WriteLine("input coordinate X to A : ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate Y to A : ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate X to A : ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate Y to A : ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between point A with coordinates ({xa},{ya} and point B with coordintaes ({ya},{yb}) -> {FindDistance(xa,ya,xb,yb)})");
*/

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

//2
/*

int FindQuart ()
{
Console.WriteLine("Введите номер четверти :");
int chet = Convert.ToInt32(Console.ReadLine());
if (chet == 1) {Console.WriteLine("x > 0 && y > 0");}
if (chet == 2) {Console.WriteLine("x < 0 && y > 0");}
if (chet == 3) {Console.WriteLine("x < 0 && y < 0");}
if (chet == 4) {Console.WriteLine("x > 0 && y < 0");}
return 0;
}
int result = FindQuart();
Console.WriteLine(result);
*/
//4
/*
int Quad (int num)
{
int count = 1;
while (count <= num)
{
    count++;
    Console.WriteLine($"Квадрат {count} -> {(count*count)}");
}
return 0;
}
Quad(11);
d*/

