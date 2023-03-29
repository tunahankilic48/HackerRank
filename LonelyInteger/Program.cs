int lonelyinteger(List<int> a)
{
    a.Sort(); // List sorted.

    List<int> temp = new List<int>(); // Temperary list created.

    for (int i = 1; i < a.Count; i++)
    {
        if (a[i - 1] == a[i]) // In here, doublicated elements were found out and added to the temp list.
        {
            temp.Add(a[i - 1]);
            temp.Add(a[i]);
        }
    }


    return a.Except(temp).FirstOrDefault(); // The difference of the A list from the temporary list has been found which means uniqeu number in the list
}