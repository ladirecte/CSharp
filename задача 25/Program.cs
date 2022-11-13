// Задача 25: Напишите цикл, который 
//принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int num1 = numberA;
int num2 = numberB;

int Result (int number)
{
int result = 1;
for (int i = 1; i<=num2; i++)
{
    result = result*num1;
}
return result;
}
int result = Result (num1);
Console.WriteLine($"число А в степени В = {result} ");