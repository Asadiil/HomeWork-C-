/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
*/
/*
int CountDigits (int num) //посчитать количество цифр в числе
{    
    int digsCount = 0;
    int temp = num;
    while (temp > 0)
    {
        temp = temp / 10;
        digsCount = digsCount + 1;
    }
    return digsCount;
}

bool IsPalindrom (int num)
{
    int count = 0;
    int digs = CountDigits(num);
    int firstDigit;
    int lastDigit;
    
    while (count < digs / 2)
    {
        firstDigit = num % Convert.ToInt32(Math.Pow(10, digs - count)) / Convert.ToInt32(Math.Pow(10, digs - count - 1));
        lastDigit = num % Convert.ToInt32(Math.Pow(10, count + 1)) / Convert.ToInt32(Math.Pow(10, count));
        System.Console.Write($"Сравниваем #{count} = {firstDigit} и #{digs - count} = {lastDigit}: ");
        if (firstDigit == lastDigit)
            {
                System.Console.WriteLine("равны !");
                count = count + 1;
            }
        else
        {
            System.Console.WriteLine("не равны");
            return false;        
        }
    } 

    return true;
}

Console.Write("Введите целое число для проверки на палиндром... ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (IsPalindrom (userNum))
    System.Console.WriteLine("Данное число - палиндром (^.^)");
else
    System.Console.WriteLine("Данное число - не палиндром (>.<)");
*/

/* Задача 21 
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
*/
/*
double InputNum(string coord, string dot)
{
    System.Console.Write($"Введите координату {coord} точки {dot}... ");
    return Convert.ToDouble(Console.ReadLine());
}

double CountVectorLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2);
    return result;
}

double x1 = InputNum("X", "A");
double y1 = InputNum("Y", "A");
double z1 = InputNum("Z", "A");
double x2 = InputNum("X", "B");
double y2 = InputNum("Y", "B");
double z2 = InputNum("Z", "B");

System.Console.WriteLine($"Длина вектора А({x1}, {y1}, {z1}), В({x2}, {y2}, {z2}) = {CountVectorLength(x1, y1, z1, x2, y2, z2)}");
*/

/* Задача 23
 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
 кубов чисел от 1 до N.
*/
/*
void PrintCubes(int num)
{
    System.Console.Write($"Таблица кубов чисел от 1 до {num}: ");
    string comma = ", ";
    for (int i = 1; i <= num; i++)
    {
        if (i == num)
            comma = "";
        System.Console.Write(Math.Pow(i, 3) + comma);
    }
}

System.Console.Write("Введите любое небольшое целое число ... ");
int userNum = Convert.ToInt32(Console.ReadLine());

PrintCubes(userNum);
*/