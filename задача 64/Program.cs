// // Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int N = 0;
while (N < 1)
{
    Console.WriteLine("Введите натуральное число или 0");
    N = Convert.ToInt32(Console.ReadLine());
    if (N == 0) return;
}
Console.WriteLine($"Числа от {N} до 1:");

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num}");
    if (num != 1) Console.Write(", ");
    NaturalNumbers(num - 1);

}
NaturalNumbers(N);
