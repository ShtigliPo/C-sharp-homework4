// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int Prompt(string message)

{
    	System.Console.Write(message);          // Вывести сообщение
    	string readValue = Console.ReadLine();  // Считавает с консоли строку
    	int result = int.Parse(readValue);      // Преобразует строку в целое число
    	return result;                          // Возвращает результат
}

int value1 = Prompt ("Введите первое число ");
int value2 = Prompt ("Введите второе число ");
if (value1 > value2) 
{
    System.Console.WriteLine ($"Число {value1} больше, чем число {value2}");
    System.Console.WriteLine ($"Число {value2} меньше, чем число {value1}");
}
if (value1 < value2) 
{
    System.Console.WriteLine ($"Число {value2} больше, чем число {value1}");
    System.Console.WriteLine ($"Число {value1} меньше, чем число {value2}");
}