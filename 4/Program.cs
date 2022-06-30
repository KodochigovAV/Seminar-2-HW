// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter => ");
string Letterdig1 = Console.ReadLine();
int A = int.Parse(Letterdig1);

if(A < 1 || A > 7)
{
    System.Console.WriteLine("Error");
    Environment.Exit(0);
}
if(A == 6 || A == 7)System.Console.WriteLine("YES");
else System.Console.WriteLine("NO");