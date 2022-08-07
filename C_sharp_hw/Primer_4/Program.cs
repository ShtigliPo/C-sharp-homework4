// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int Prompt(string message)

{
    	System.Console.Write(message);          // Вывести сообщение
    	string readValue = Console.ReadLine();  // Считавает с консоли строку
    	int result = int.Parse(readValue);      // Преобразует строку в целое число
    	return result;                          // Возвращает результат
}

int N;
N = Prompt ("Введите число ");
 
 for (int i = N; i <= N; i++)
{
    System.Console.WriteLine(i);
}

//System.Console.WriteLine("Введите число ");
//string Value = Console.ReadLine();
//int number = int.Parse (value);
//int result = -(number + 1);
//while (result !-number)
//{
//	result+++
//	System.Console.WriteLine(result);
//} 