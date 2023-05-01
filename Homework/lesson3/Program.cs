//1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void palindrom ()
{
    Console.WriteLine("Введите 5 значное число :");
    int num = Convert.ToInt32(Console.ReadLine());
    if ((num % 10) == (num / 10000) && (num / 1000) % 10 == (num % 100)/ 10)
    {Console.WriteLine("Число полиндром.");}
    else {Console.WriteLine("Число не полиндром");}
}
palindrom();
*/
//2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
void distance3d ()
{
Console.WriteLine("Введите координаты точки A по оси X :");
double ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Y :");
double ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Z :");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси X :");
double bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Y :");
double by = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Z :");
double bz = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((bz - az),2));
Console.WriteLine($"Расстояние между точками -> {Math.Round(distance,2)}");
}
distance3d (); 
*/

//3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void cubtable()
{
    Console.WriteLine("Введите число : ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} -> {Math.Pow(count,3)}");
        count++;
    }
}
cubtable();
*/