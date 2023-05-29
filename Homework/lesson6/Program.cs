//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

/*void Polozh_num()
{
Console.WriteLine("Введите числа, через запятую :");
string nums = Console.ReadLine();
string[] nums_array = nums.Split(new char[] {','});
int count_num = 0;
for(int i = 0; i < nums_array.Length; i++)
{
    int num = Convert.ToInt32(nums_array[i]);
    if(num > 0) count_num++;
}
Console.WriteLine($"Колличество чисел больше 0 -> {count_num}");
}
Polozh_num();*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD1 = 1;
const int Y_COORD2 = 2;
const int LINE1 = 1;
const int LINE2 = 2;

   double[] InputLineData(int numberOfLine) 
    {
        double[] lineData = new double[2];
        lineData [COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
        lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
        return lineData;
    } //создаём массив из двух чисел с индексами COEFFICIENT = 0; CONSTANT = 1;

double[] lineData1 = InputLineData (LINE1);
double[] lineData2 = InputLineData (LINE2);

double[] FindCoords (double[] lineData1, double[] lineData2)
    {
        double[] coord = new double[3];
        coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
        coord[Y_COORD1] = lineData1[COEFFICIENT] * coord[X_COORD] + lineData1[CONSTANT];
        coord[Y_COORD2] = lineData2[COEFFICIENT] * coord[X_COORD] + lineData2[CONSTANT];
        //двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
        //
        return coord;
    }//метод для вычисления координат

bool ValidateLines (double[] lineData1, double[] lineData2)
    {
        if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
        {
            if (lineData1[CONSTANT] == lineData2[CONSTANT])
            {
                Console.WriteLine("прямые совпадают");
                return false;
            }
            else {
                Console.WriteLine("прямые параллельны");
                return false;
            }

        }
        return true;
    }

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords (lineData1, lineData2);
    Console.WriteLine($"точка пересечения уравнений y={lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и y={lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]}");
    Console.WriteLine($"имеет координаты ({coord[Y_COORD2]}, {coord[Y_COORD1]})");
}

double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
/*/



