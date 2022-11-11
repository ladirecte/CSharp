// напишите программу, которая 
// на вход принимает число и
// выдает количество цмфр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int numDigit)
{
    numDigit = Math.Abs(numDigit); //для отрицательных чисел
    int count = 0;
    while (numDigit > 0)
    {
        numDigit = numDigit / 10;
        count++;
    }
    return count > 0 ? count : 1;
}
int sumDigit = SumDigit(num);
System.Console.WriteLine($"количество цифр в числе = {sumDigit}");