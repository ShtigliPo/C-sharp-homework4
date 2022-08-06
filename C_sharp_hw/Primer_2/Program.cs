// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int Prompt(string message)

{
    	System.Console.Write(message);          // Вывести сообщение
    	string readValue = Console.ReadLine();  // Считавает с консоли строку
    	int result = int.Parse(readValue);      // Преобразует строку в целое число
    	return result;                          // Возвращает результат
}

int value1 = Prompt ("Введите первое число ");
int value2 = Prompt ("Введите второе число ");
int value3 = Prompt ("Введите третье число ");

if (value1 > value2) {

if (value1 > value3) 
{
    System.Console.WriteLine ($"Число {value1} самое большое");
}
}
if (value2 > value1) {
   
if (value2 > value3) 
{
    System.Console.WriteLine ($"Число {value2} самое большое");
}
}
if (value3 > value2) 
{
if (value3 > value1) 
{
    System.Console.WriteLine ($"Число {value3} самое большое");
}
}