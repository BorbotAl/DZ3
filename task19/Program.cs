// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool FiveDigits(int num)
{
    if (num < 0) num = -num;
    return num > 9999 && num < 100000;
}

string IsPalindrome(int num)
{
    int firstDig = num / 10000;
    int secondDig = (num / 1000) % 10;
    int fourthDig = (num / 10) % 10;
    int fifthDig = num % 10;
    if (firstDig == fifthDig && secondDig == fourthDig) return $"Число {num} является палиндром";
    return $"Число {num} не является палиндром";
}

if (FiveDigits(number)) Console.WriteLine(IsPalindrome(number));
else Console.Write ("Введеное число не является пятизначным");