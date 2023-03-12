//Домашка раз.
/*
задача2. Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/
/*
Console.WriteLine("Введите значение 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.WriteLine($"{a} больше {b}");
else if (a < b) Console.WriteLine($"{b} больше {a}");
else Console.WriteLine($"{b} равно {a}");*/

/*
задача4. Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
*/
/*
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a >= b && a >= c) Console.WriteLine($"Максимальное число: {a}");   
else if (b > a && b >= c) Console.WriteLine($"Максимальное число: {b}");
else Console.WriteLine($"Максимальное число:  {c}");
*/

/*
задача6. Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 2 == 0 ? "Число чётное" : "Число не чётное");
*/

/*
задача8. Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/
/*
Console.Write("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

if(count == 1) count += 1;
while(count <= num) 
    {
        Console.WriteLine(count); count += 2;
    }
*/