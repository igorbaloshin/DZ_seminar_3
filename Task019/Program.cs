// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
//-----------------------------------------------------
int CountNumbers(int n)
{
    int count = 0;
    if(n < 0)
       n *= (-1); // n = n*(-1)
    while(n > 0)
    {
        n /= 10; // n = n / 10
        count++;

    }
    return count;
} 
//--------------------------------------------------------
void FillArray(int[] array, int K)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = (K % Convert.ToInt32(Math.Pow(10, length - index)) - K % Convert.ToInt32(Math.Pow(10, (length - index - 1)))) / (Convert.ToInt32(Math.Pow(10, length - index - 1)));
        index++;
    }
}
//---------------------------------------------------------------Проверочный цикл
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }


}

//---------------------------------------------------------------------

bool CheckArray(int[]array)
{
    int length = array.Length;
    int index = 0;
    bool check = false;
    while(index <= length/2)
    {
        if(array[index] == array[length-1-index])
        check = true;
        else
        {
        check = false;
        return check;
        }
        index++;
    }
    return check;
}

Console.WriteLine("Введите число : ");
int Polindrom = int.Parse(Console.ReadLine());

int N = CountNumbers(Polindrom);

int[]polindrom = new int[N];

FillArray(polindrom, Polindrom);

//PrintArray(polindrom);

bool Ch = CheckArray(polindrom);

if(Ch == false)
Console.WriteLine("Число не полиндром");
if(Ch == true)
Console.WriteLine("Число полиндром");

