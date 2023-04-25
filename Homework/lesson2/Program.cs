//1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void TwoDigit (int num)
{
    int result = (num % 100) / 10;
    Console.Write($"Второе число -> {result}");
}
TwoDigit(164);
*/

//2  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThreeDigit (int num)
{
    // Проверяем что число не трёхзначное. т.к любое не трёхзначное при делении на 100 в int даст 0
    if (num / 100 == 0) {Console.WriteLine("Число не трёхзначное !");} 
    else {
    int num_m = num;
    //
    int exp_num = 1;
    while(num_m != 0)
{
num_m = num_m / 10;
exp_num = exp_num * 10;
}
exp_num = exp_num / 100;
int result = (num % exp_num) / (exp_num / 10);
Console.WriteLine($"Третья цифра числа -> {result}");
}}
ThreeDigit(478568795);