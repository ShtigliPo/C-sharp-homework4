// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int a;
a = Prompt ("Введите число  ");
int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a / 10;
}
Console.WriteLine($"Сумма цифр в числе  : {sum}");