﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;

for (int i = 1; i < b; i++)
{
result = result * a;
}
Console.WriteLine("A в степени B равно " + result);