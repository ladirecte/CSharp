// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.WriteLine("Введите массив");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RndNum(array);
Console.WriteLine("Массив: ");
PrintArray(array);
int num = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
num++;

Console.WriteLine($"введено чисел {array.Length}, четные {num}");

void RndNum(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
    //Console.WriteLine();
}
