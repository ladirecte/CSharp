// Задача 27: Напишите программу, которая 
//принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int numDigit)
{
    //numDigit = Math.Abs(numDigit); //для отрицательных чисел
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum > 0 ? sum : 1;
}
int sumDigit = SumDigit(num);
Console.WriteLine($"сумма цифр в числе = {sumDigit}");
