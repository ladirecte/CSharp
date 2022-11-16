// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
RandomNumbers(array);
Console.Write("  : ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"всего чисел {array.Length}. Макс. значение = {max}, мин. значение = {min}");
Console.WriteLine($"Разница между макс. и мин. значением = {max - min}");

void RandomNumbers(double[] array)

       
{
    for(int i = 0; i < array.Length; i++)
        {
             //double num = rnd.NextDouble() * (max - min) + min;
            //array[i] = Math.Round(num, 1);
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100 % 100;
        }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}









//int[] CreateArrayRndInt(int size, int min, int max)
//{
//  int[] array = new int[size];
//  Random rnd = new Random();
// for (int i = 0; i < size; i++)
//{
//  array[i] = rnd.Next(min,max + 1);
//}
//return array;
//}
//Console.WriteLine("Массив ");

//double[] CreateArrayRndDouble(int size, int min, int max)  // метод для вещественных чисел
//{
  //  double[] array = new double[size];
    //Random rnd = new Random();

    //for (int i = 0; i < size; i++)
    //{
      //  double num = rnd.NextDouble() * (max - min) + min;
        //array[i] = Math.Round(num, 1);
    //}
    ///return array;
//}
//void PrintArray(double[] array)
//{
  //  Console.Write("[");
    //for (int i = 0; i < array.Length; i++)
    //{
      //  array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        //if (i < array.Length + 1) Console.Write($"{array[i]},");
        //else Console.Write($"{array[i]},");
    //}
    //Console.WriteLine("]");

//}
//double GetCountElements(double[] array)
//{
    //Console.Write("[");
  //  double count = 0;
    //for (int i = 1; i < array.Length; i++)
    //{
        //if (array[i] >= 1 && array[i] <= 99) count++;
      //  Console.Write(array[i] + " ");
    //}
    //return count;
    //Console.WriteLine("]");
//}
///double[] arr = CreateArrayRndDouble(10, 1, 99);
//PrintArray(arr);
//d/ouble result = GetCountElements(arr);
//Console.WriteLine($"разницу между максимальным и минимальным элементов массива = {result}");
