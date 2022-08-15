int Sum(int a)
{
    int result = 0;
    for (int number = 0; number <= a; number++)
    {
        result += number;
    }
    return result;
}
Console.WriteLine(Sum(5));