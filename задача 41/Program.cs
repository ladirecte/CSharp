//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Write("Введите значения, через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int num = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        num++;
    }
}
Console.WriteLine();
Console.WriteLine($"значения больше 0 = {num}");


int[] StringToNum(string number)
{
    int count = 1;
    for (int i = 0; i < number.Length - 1; i++)
    {
        if (number[i] == ',')
        {
            count++;
        }
    }
    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < number.Length; i++)
    {
        string temp = "";

        while (number [i] != ',')
        {
        if(i != number.Length - 1)
        {
            temp += number [i].ToString();
            i++;
        }
        else
        {
            temp += number [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

//Console.WriteLine("введите числа: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int[] NumberM(int num)
//{
  //  int[] arrayNumber = new int[num];
   // arrayNumber[1] = 1;
    //for (int i = 0; i <= num; i++)
    //{
      //  arrayNumber[i] = num > 0;
    ///}
    //return arrayNumber;
//}

///void PrintArray(int[] array)
//{
  //  Console.Write("[");
    //for (int i = 0; i < array.Length; i++)
    //{
      //  if (i < array.Length - 1) Console.Write($"{array[i]},");
        //else Console.Write($"{array[i]}");
    //}
    //Console.WriteLine("]");
//}

//int[] numberArray = NumberM(number);
//PrintArray(numberArray);

