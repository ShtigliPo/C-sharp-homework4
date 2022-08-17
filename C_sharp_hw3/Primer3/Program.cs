// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void SetN(int num)
{
    int i = 1;
    while (i <= num)
    {
        System.Console.Write(i * i * i + " ");
        i++;
    }
}
int numb = Prompt("Введите число ");
System.Console.WriteLine($"Таблица кубов от 1 до {numb}:");
SetN(numb);

