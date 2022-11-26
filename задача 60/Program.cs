// /Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Например, задан массив размером 2 x 2 x 2.
//Результат:
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] Create3dMatrixRndInt(int rows, int columns, int depth, int[] arrayRnd)
{
    int count = 0;
    int[,,] array3d = new int[rows, columns, depth];
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int l = 0; l < array3d.GetLength(2); l++)
            {
                array3d[i, j, l] = arrayRnd[count];
                count++;
            }
        }
    }
    return array3d;
}
int[] arrayRandom() 
{
    Random rnd = new Random();
    int[] array = new int[90];
    for (int i = 0; i < 90; i++)
    {
        int b = rnd.Next(10, 100);
        for (int j = 0; j < array.Length; j++)
        {
            if (b == array[j])
            {
                b = rnd.Next(10, 100);
                j = 0;
            }
        }
        array[i] = b;
    }
    return array;
}
void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        Console.Write($"| ");
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int l = 0; l < array3d.GetLength(2); l++)
            {
                Console.Write($"{array3d[i, j, l],5} ({i},{j},{l})");
                if (j < array3d.GetLength(1) - 1) Console.Write("  ");
            }
        }
        Console.WriteLine(" |");
    }
}


int[] arrayRnd = arrayRandom();

Console.Write("Количество строк : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Глубина массива : ");
int c = Convert.ToInt32(Console.ReadLine());


int[,,] MatrixRndInt = Create3dMatrixRndInt(a, b, c, arrayRnd);
Console.WriteLine("массив со случайными целыми числами ");
PrintArray3d(MatrixRndInt);
Console.WriteLine("    ");
