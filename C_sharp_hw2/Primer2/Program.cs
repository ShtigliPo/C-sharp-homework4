// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);
int num1 = 10 * ( num / 100 )  + ( num % 10 );
System.Console.WriteLine(num1);