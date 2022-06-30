// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Enter => ");
string Letterdig1 = Console.ReadLine();
int A = int.Parse(Letterdig1);
Console.Write(A%100/10);