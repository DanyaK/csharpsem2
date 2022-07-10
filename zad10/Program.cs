﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/

Console.WriteLine("Task 10!");

Console.Write("Your number = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 || number < 100) 
{
    Console.WriteLine("Wrong input");
}
else 
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine("Second digit is " + secondDigit);
}