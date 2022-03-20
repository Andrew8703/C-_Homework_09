// Задача 69: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму элементов в промежутке от M до N.

Console.Clear();

Console.Write("M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("N: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int NaturalNumber(int m, int n)
{
    if (m < n)
    {
        sum += m;
        NaturalNumber(m + 1, n);
        return sum + n;
    }
    else if (m > n)
    {
        sum += n;
        NaturalNumber(m, n + 1);
        return sum + m;
    }
    else return 0;
}
Console.WriteLine($"\nСумма элементов от M до N равна: {NaturalNumber(m, n)}\n");
