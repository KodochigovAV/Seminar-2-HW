// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Enter => ");
string Letterdig1 = Console.ReadLine();
int A = int.Parse(Letterdig1);
if (A < 100)
{
    System.Console.WriteLine("No");
    Environment.Exit(0);
}
while (A > 999) A = A / 10;
A = A % 10;
System.Console.WriteLine(A);