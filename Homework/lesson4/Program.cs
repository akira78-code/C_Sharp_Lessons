//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int NaturStepen(int num, int stepen)
{
    int CopyNum = num;
    int r = 0;
   for(int count = 1; count<stepen;count++)
   {
        
        r = CopyNum*num;
        Console.WriteLine(CopyNum);
        CopyNum = r;
   }
   return CopyNum;
}
Console.WriteLine($"{NaturStepen(2,3)} - результат");*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*

int SumCifr(int num)
{
    int a = 10;
    int b = 1;
    int i = 1;
    int result = 0;
    while(i != 0)
    {
        i = (num%a)/b;
        result+=i;
        a*=10;
        b*=10;
    }
    return result;
}
Console.WriteLine(SumCifr(1234));*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*void CreateArroy()
{
   Console.WriteLine("Введите числа, через запятую :");
   string nums =  Console.ReadLine();
   string [] arroy = nums.Split(new char[] {','});
   foreach(string i in arroy)
   {
    Console.WriteLine(i);
   }
}
CreateArroy();*/