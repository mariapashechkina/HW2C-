// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int Method(int a)
{
    int sot = a/100;
    int result = (a - sot*100)/10;
    return result;
}

Console.Write ("Enter number of threes: ");
int a = Convert.ToInt32(Console.ReadLine());
Method(a);
Console.WriteLine($"New version of a number {a} is {Method(a)}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

Console.Write ("Enter any number: ");
int a = Convert.ToInt32(Console.ReadLine());

int number = a;
int digitIndex = 2; 
int digit = number.ToString()[digitIndex] - '0';

Console.WriteLine($"The third number is {digit}");

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Method(int num)
{
    if(num > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
    
}

Console.Write("Enter a number for the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = Method(num);
Console.WriteLine(res);
*/


