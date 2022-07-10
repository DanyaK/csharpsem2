/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/

Console.WriteLine("Task 15!");

Console.Write("Your number = ");
int input =  Convert.ToInt32(Console.ReadLine());

if (input < 1 || input > 7)
{
    Console.WriteLine("Wrong input");
}
else if (input == 7 || input == 6)
{
    Console.WriteLine(input + " -> yes");
}
else
{
    Console.WriteLine(input + " -> no");
}
