// Напишите программу вычисления модуля числа.

int Prompt(string message)
{
    	System.Console.Write(message);          // Вывести сообщение
    	string readValue = Console.ReadLine();  // Считавает с консоли строку
    	int result = int.Parse(readValue);      // Преобразует строку в целое число
    	return result;                          // Возвращает результат
}

int value = Prompt ("Введите число ");
int newValue = value;
if (value < 0)
{
    newValue = -value;
};

System.Console.WriteLine($"{newValue}");
