//Напишите программу, которая принимает
//на вход число (А) -- (т.е пользовательский , не должно быть random) и
//выдает сумму чисел от 1 до А
// 7 -> 28
// 4-> 10
// 8 -> 36

Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default;
    for (int i = 1; i <= number; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(num);
Console.WriteLine($"сумма чисел от 1 до {num} = {sumNumbers}");
