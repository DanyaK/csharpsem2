/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Task 13!");

Console.Write("Your number = ");
int input =  Convert.ToInt32(Console.ReadLine());
int number = input;
int count = 0;

if (number < 100) 
{
    Console.WriteLine(number + " -> no third digit");
}
else 
{
    while (number > 1000)
    {
        number = number / 10;
    }

    int thirdDigit = number % 10;

    Console.WriteLine(input + " -> " + thirdDigit);
}