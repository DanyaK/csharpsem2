/*
Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.WriteLine("Task 16!");

Console.Write("First number = ");
int inputFirst =  Convert.ToInt32(Console.ReadLine());

Console.Write("Second number = ");
int inputSecond =  Convert.ToInt32(Console.ReadLine());

if (inputFirst*inputFirst == inputSecond || inputSecond*inputSecond == inputFirst) 
{
    Console.WriteLine(inputFirst + ", " + inputSecond + " -> yes");
}
else
{
    Console.WriteLine(inputFirst + ", " + inputSecond + " -> no");
}


