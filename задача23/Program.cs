// Напишите программу, которая принимает 
//на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i,4}  {i*i*i,4}");
        }
    }
    else
    {
        Console.WriteLine("Введите значенте больше 0");
    }
}

SquareTable(n);
