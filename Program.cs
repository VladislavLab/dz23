// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число ");
int x = int.Parse(Console.ReadLine()!);
int b=1;
Console.Write(" получаем числа ");
while (b<=x) 
{
//int res = b*b;
double res= Math.Pow((b),3);

//Console.Write(res+" ");
//Console.Write($" {res:f2} ");
Console.Write($"{(Math.Round(res,2))}");
if (b!=x)
{
    Console.Write(", ");
}
b++;
}