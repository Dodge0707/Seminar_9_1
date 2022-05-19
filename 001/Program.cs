// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Console.WriteLine("Задайте число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = Rekurs(n);
// Console.WriteLine(result);

// int Rekurs(int number)
// {  
//     if (number == 1)
//         return 1; 
//     Console.Write(Rekurs(number -1));
//    return number;
    
// }

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// int numberStart = Input("Введите значение M: ");
// int numberEnd = Input("Введите значение N: ");

// Console.WriteLine(OutputFunction(numberStart, numberEnd));

// int Input(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int OutputFunction(int numStart, int numEnd)
// {
//     if (numEnd == numStart)
//     {
//         return numEnd;
//     }
//     Console.Write(OutputFunction(numStart, numEnd- 1) + ", ");
//     return numEnd;
// }

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = Numbers(number);
// Console.WriteLine(result);

// int Numbers(int number)
// {   
//     if (number > 0)
//     {
//         return number%10 + Numbers(number/10);
//     }
//     return 0;
// }

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write($"Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DegNuber(numberA, numberB));
double DegNuber(int a, int b)
{
    if (b > 1) return a*DegNuber(a, b-1);
    else return 1;
}