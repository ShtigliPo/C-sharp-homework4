// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int value1 = Prompt("Введите первое число ");
int value2 = Prompt("Введите второе число ");
if (value1 * value1 == value2) {
    System.Console.WriteLine("Да");
 }else{
    System.Console.WriteLine("Нет");
}