// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Количество строк двумерного массива : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов двумерного массива : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальный элемент массива : ");
int minN = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальный элемент массива : ");
int maxN = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" |");
    }
}

double[] SumElementsInColumns(int[,] matrix)
{
    double arithmeticMean = 0;
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++) 
    {
        for (int j = 0; j < matrix.GetLength(0); j++) 
        {
            arithmeticMean += matrix[j, i];
        }
        arithmeticMean /= matrix.GetLength(0);
        array[i] = Math.Round(arithmeticMean, 1);
        arithmeticMean = 0;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 1),4}");
        if (i < array.Length - 1) Console.Write(" |");

    }
    Console.WriteLine(" ]");
}

int[,] newMatrixRnd = CreateMatrixRndInt(a, b, minN, maxN);
Console.WriteLine();
Console.WriteLine("массив заполненный случайными целыми числами");
PrintMatrix(newMatrixRnd);

double[] arithmeticMeanElementsInColumns = SumElementsInColumns(newMatrixRnd);
Console.WriteLine();
Console.WriteLine("среднее арифметическое элементов в каждом столбце");
PrintArray(arithmeticMeanElementsInColumns);