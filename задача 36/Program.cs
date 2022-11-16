// Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RndNumbers(array);
PrintArray(array);


int num = 0;
for (int i = 0; i < array.Length; i = i + 2)
    num = num + array[i];

Console.WriteLine($"всего чисел {array.Length}, сумму элементов, на нечётных позициях = {num}");


void RndNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }

}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
    Console.WriteLine();
}
//PrintArray(array);  что-то пошло не так/ не понимаю как выйти на нечётные