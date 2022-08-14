// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)

{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}

int dayOfWeek;
dayOfWeek = Prompt($"Введите число ");

if (dayOfWeek < 1 || dayOfWeek > 7)
{
    System.Console.WriteLine("Это не день недели");
    return;
}
if (dayOfWeek == 6 || dayOfWeek == 7)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}