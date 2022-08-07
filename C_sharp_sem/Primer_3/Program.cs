// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int N;
N = Prompt ("Введите число ");
 
 for (int i = -N; i <= N; i++)
{
    System.Console.WriteLine(i);
}