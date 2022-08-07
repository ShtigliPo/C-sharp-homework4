// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int dayNum;

dayNum = Prompt("Введите номер дня недели ");
if (dayNum <= 0) {
    System.Console.WriteLine("Нет такого дня недели! ");
} else if (dayNum >= 8) {
    System.Console.WriteLine("Нет такого дня недели! ");
} else if (dayNum == 1) {
    System.Console.WriteLine("Понедельник");
} else if (dayNum == 2) {
    System.Console.WriteLine("Вторник");
} else if (dayNum == 3) {
    System.Console.WriteLine("Среда");
} else if (dayNum == 4) {
    System.Console.WriteLine("Четверг");
} else if (dayNum == 5) {
    System.Console.WriteLine("Пятница");
} else if (dayNum == 6) {
    System.Console.WriteLine("Суббота");
} else if (dayNum == 7) {
    System.Console.WriteLine("Воскресенье");
}


