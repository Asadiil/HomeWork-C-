//Домашка два
/*
Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.
*/
/*
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int MiddleNumber (int a)
    {
        return a / 10 % 10;
    }
int result = MiddleNumber(a);
Console.WriteLine(result);
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Third (int a)
    { 
        while(a >= 1000)
            {
                a = a / 10;
            }
        return a = a % 10;
    }
if (a < 100)
    {
        Console.Write ("Нету трьего числа");
    }
else Console.WriteLine(Third(a));
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
/*
Console.WriteLine("Введите число дня недели");
int a = Convert.ToInt32(Console.ReadLine());

bool IsSevenWeek (int a)
    {
        if (a >= 1 && a <= 7)
        {
            return true;
        }
        return false;
    }
bool IsNotWeekEnd (int a)
    {
        if (a >= 1 && a <= 5)
            {
                return true;
            }
        return false;
    }

if(!IsSevenWeek(a)) Console.WriteLine("дурачок?");
else if(IsNotWeekEnd(a)) Console.WriteLine("Работать!!!");
else Console.WriteLine("Выходной");
*/