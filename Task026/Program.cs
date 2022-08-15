int LenNumber(int number)
{
    int mylen = 0;
    while (number != 0)
    {
        mylen++;
        number = number / 10;
    }
    return mylen;
}
void PrintRes(int res)
{
    Console.WriteLine(LenNumber(res));
}
PrintRes(10000);