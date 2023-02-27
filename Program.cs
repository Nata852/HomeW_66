int GetNumber(string message)
{
    int resalt = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resalt))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return resalt;
}

int SumRec(int m, int n)
{
    
    if (m == n) return 0;

    else
    {
        m++;
        return m + SumRec(m, n);
    }
}
int m = GetNumber("Введите M -> ");
int n = GetNumber("Введите N -> ");
Console.WriteLine(SumRec(m-1, n));
