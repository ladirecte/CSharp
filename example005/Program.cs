﻿// Напишите программу, которая 
// 1.на вход принимает одно число (N) 
// 2. а на выходе показывает 
// все целые числа в промежутке от -N до N
// 4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2-> "-2, -1, 0, 1, 2"

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
        //count = count + 1;  
    }
}
else Console.WriteLine("введите целое положительное число!");
