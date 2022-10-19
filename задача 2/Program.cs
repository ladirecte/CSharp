// Задача 2: Напишите программу, которая 
// 1.на вход принимает два числа и 
// 2.выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

// string str = Console.ReadLine();
// int num = Convert.ToInt32(str);

if (number1 < number2)
{
    Console.WriteLine ("yes");
}
else
{
    Console.WriteLine("no");
}