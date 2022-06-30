// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100, 1000);
System.Console.WriteLine("Number ->" + number);

int result = (number/100)*10 + number % 10;

System.Console.WriteLine("Result -> " + result);