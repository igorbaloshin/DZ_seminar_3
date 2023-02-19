// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число:  ");
int N = int.Parse(Console.ReadLine());

int Kub(int a)
{
    int S = Convert.ToInt32(Math.Pow(a, 3));
    return S;
}

void Print(int b)
{
    Console.Write($"{b}, ");
}
if (N >= 0)
{
    for(int i = 0; i <= N; i++)
{
    int S = Kub(i);
    Print(S);
}
}
if (N < 0)

for(int i = N; i <= -1; i++)
{
    int S = Kub(i);
    Print(S);
}
