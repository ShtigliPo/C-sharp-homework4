// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.

int Prompt(string message)

{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}


int num1;
int num2;
num1 = Prompt("Введите первое число ");
num2 = Prompt("Введите второе число ");
int ost = num1 % num2;
if (ost == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"Не кратно, остаток {ost}");
}
