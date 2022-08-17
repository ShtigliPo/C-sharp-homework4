// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

void palindrom()
{
    System.Console.Write("Введите 5ти значное число ");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int value = number / 10000;

    if (value < 1 || value > 9)
    {
        Console.WriteLine(number + " -> " + "не 5ти значное число");
    }
    else if (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine(number + " -> Да, число палиндром");
    }
    else
    {
        Console.WriteLine(number + " -> Нет, число не палиндром");
    }
}
palindrom();

