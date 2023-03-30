void minimumBribes(List<int> q)
{
    bool isChaotic = false;
    int bribesCount = 0;
    for (int i = 0; i < q.Count; i++)
    {
        if (q[i] - (i + 1) > 2)
        {
            isChaotic = true;
            break;
        }
        for (int j = Math.Max(0, q[i] - 2); j < i; j++)
        {
            if (q[j] > q[i])
            {
                bribesCount++;
            }
        }

    }

    if (isChaotic)
    {
        Console.WriteLine("Too chaotic");
    }
    else
    {
        Console.WriteLine(bribesCount);
    }

}

minimumBribes(new List<int>() { 1, 2, 5, 3, 4, 7, 8, 6 });