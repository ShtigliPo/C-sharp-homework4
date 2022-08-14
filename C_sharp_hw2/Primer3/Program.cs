// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)

{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}

int Get3Digit(int value)
{
    while (value > 1000)
    {
        value = value / 10;
    }
    int result = value % 10;
    return result;
}

int value = Prompt("Введите число  ");
if (value > 99)
{
    int result = Get3Digit(value);
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("У числа третьей цифры нет");
}