// напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случ порядке   [1.0.1.1.0.1.0.0]

Console.WriteLine("Введите количество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}
int[] nameArray = NameArray(num);
PrintArray(nameArray);
