// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int a;
int n;
a = Prompt("Введите первое число ");
n = Prompt("Введите второе число ");
int res = 1;
for (int i = 1; i <= n; i++)
{
    res = res * a;
}
Console.WriteLine($"{a} в степени {n} равно {res}");
if (n < 0)
{
    System.Console.WriteLine("По условиям задачи, второе число должно быть натуральным");
}