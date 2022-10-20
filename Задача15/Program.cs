// Задача 15: Напишите программу, которая 
//принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6)
{
    Console.WriteLine("выходной");
}
else if (number == 7)
{
    Console.WriteLine("выходной");
}
else if (number >= 1 && number < 6)
{
    Console.WriteLine("будний день");
}
else if (number >= 8)
{
  Console.WriteLine("в неделе 7 дней");
}
