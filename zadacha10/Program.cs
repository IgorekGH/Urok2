//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Напишите трехзначное число");
int a=Convert.ToInt32(Console.ReadLine());
a = ( a % 100) / 10;
Console.WriteLine (a);