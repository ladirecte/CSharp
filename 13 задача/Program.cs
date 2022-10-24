// Задача 13: Напишите программу, которая 
//выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//int FirstDigit = (number % 100) / 10; //четырехзначное
//Console.WriteLine($"третья цифра числа => {FirstDigit}");

int result = number;

int SecondDigit = number % 10; // трехзнач
if (SecondDigit > 99) result = SecondDigit;
else result = SecondDigit;
Console.WriteLine($"третья цифра числа => {SecondDigit}");

int thirtDigit = ((number % 10) / 100); //двухзнач
if (thirtDigit < 9) result = thirtDigit;
else result = thirtDigit;
Console.WriteLine($"третьей цифры нет ");

int FirstDigit = (number % 1000) / 100; // пятизнач
if (FirstDigit < 9999) result = FirstDigit;
else result = FirstDigit;
Console.WriteLine($"третья цифра числа => {FirstDigit}");

