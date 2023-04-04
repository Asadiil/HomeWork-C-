//Домашка четыре.

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B. 3, 5 -> 243 (3⁵)*/
/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int GetExponentiation (int number, int exponent)
{
    int result = 1;
    for(int i = 1; i <= exponent; i++)
        result = result * number;

    return result;
}

int userNum = UserInput("Введите целое число");
int userExponent = UserInput("Введите степень для этого числа");

System.Console.WriteLine($"Результат возведения {userNum} в степень {userExponent} = {GetExponentiation(userNum, userExponent)}.");
System.Console.WriteLine($"Проверка: Math.Pow({userNum}, {userExponent}) = {Math.Pow(userNum, userExponent)}.");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/
/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int userNum = UserInput("Введите целое число");

System.Console.WriteLine("Сумма цифр в этом числе = " + SumDigits(userNum));
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/
/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int[] FillUserArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = UserInput($"Введите {i}-й элемент массива");

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write(arr[i] + ", ");
    Console.Write(arr[arr.Length-1] + "]");
}

int[] myArray = FillUserArray(UserInput("Введите длину желаемого массива"));
System.Console.WriteLine("Заполненный Вами массив выглядит так: ");
PrintArray(myArray);
*/