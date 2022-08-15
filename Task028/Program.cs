double myfactoril(double a)
{

    double myfactoril = 1;
    for (int i = 1; i <= a; i++)
    {
        myfactoril *= i;
    }

    return myfactoril;
}

// Console.WriteLine("Введите произвольное число");
Console.WriteLine(myfactoril(10));