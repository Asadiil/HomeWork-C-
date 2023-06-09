// Домашка пять.

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. */
/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0;  i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0 ; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine(array[array.Length - 1]);
}

int CountEvenNumbers(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) counter += 1;
    }
    return counter;
}

int arrSize     = UserInput("Введите размер массива трёхзначных чисел");
int arrBorderMin = 100;
int arrBorderMax = 1000;

int[] myArray = CreateRandomArray(arrSize, arrBorderMin, arrBorderMax);
WriteArray(myArray);

Console.WriteLine("Количество чётных чисел в массиве =" + CountEvenNumbers(myArray));
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях. */
/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0;  i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0 ; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine(array[array.Length - 1]);
}

int OddIndexCounter(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int arrSize      = UserInput("Введите размер массива");
int arrBorderMin = UserInput("Введите минимальную границу для генерации");
int arrBorderMax = UserInput("Ведите максимальную границу для генерации");

int[] myArray = CreateRandomArray(arrSize, arrBorderMin, arrBorderMax);
WriteArray(myArray);

Console.WriteLine("Сумма элементов на нечётных позициях = " + OddIndexCounter(myArray));
*/

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/
/*

double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0;  i < size; i++)
        array[i] = Math.Round(new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2), 2);
    
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0 ; i < array.Length; i++)
        Console.Write($"{array[i]}   ");
    
    Console.WriteLine();
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];

    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) max = array[i];
        
    return max;
}

int arrSize      =  10;
int arrBorderMin = -20;
int arrBorderMax =  20; 

double[] myArray = CreateRandomDoubleArray(arrSize, arrBorderMin, arrBorderMax);
System.Console.WriteLine($"Массив из элементов {arrSize} в интервале от {arrBorderMin} до {arrBorderMax}:");
WriteArray(myArray);

double min = FindMin(myArray);
double max = FindMax(myArray);
double minMaxDifference = Math.Round(max - min, 2);
System.Console.WriteLine($"Разница между min = {min} и max = {max} составляет {minMaxDifference}; ");
*/