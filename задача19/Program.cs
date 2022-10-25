// Напишите программу, которая
// принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FirstDigit = (number / 10000);
int SecondDigit = number % 10;

Console.WriteLine($"первая цифра числа => {FirstDigit}");
Console.WriteLine($"последняя цифра числа => {SecondDigit}");

int lastDigit = (number / 1000) % 10;
int thirtDigit = (number /10) % 10;

Console.WriteLine($"вторая цифра числа => {lastDigit}");
Console.WriteLine($"четвертая цифра числа => {thirtDigit}");

//if (number > 0 && number < 9) FirstDigit = (number / 10000);
//else if (number > 9999 && number < 99999) SecondDigit = number % 10;
//else if (number > 9 && number < 99) lastDigit = (number / 1000) % 10;
//else if (number > 999 && number < 9999) thirtDigit = (number /10) % 10;
Console.WriteLine("Число Палиндром "); //=> {FirstDigit}, {SecondDigit} , {lastDigit} , {thirtDigit}");

//if ({FirstDigit = (number / 10000)) = ({lastDigit = (number / 1000) % 10)
//else if (number > 999 && number < 10000) SecondDigit = number % 10;

//Console.WriteLine($"число не является палиндромом");
