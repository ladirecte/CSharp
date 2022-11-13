// Задача 29: Напишите программу, которая 
//задаёт массив из 8 элементов и 
//выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите количество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 33);
    }
    return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] =new Random().Next(1, 100);
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}
int[] nameArray = NameArray(num);
PrintArray(nameArray);

