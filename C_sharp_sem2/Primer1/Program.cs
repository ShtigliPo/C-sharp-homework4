// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.


int Prompt(string message)

{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}

int number = Prompt("Введите 3-х значное число  ");
int result = number % 10;
Console.WriteLine(result);

