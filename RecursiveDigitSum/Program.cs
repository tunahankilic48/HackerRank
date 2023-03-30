int superDigit(string n, int k)
{
    n = n.Replace("0", "");
    long sum = 0;

    for (int i = 1; i < 10; i++)
    {
        string temp = n.Replace(i.ToString(), "");
        sum += i * (n.Length - temp.Length);
        n = temp;
    }
    sum *= k;
    if (sum < 10)
    {
        return (int)sum;
    }
    else
    {
        return superDigit(sum.ToString(), 1);
    }
}