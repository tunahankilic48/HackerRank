﻿List<int> countingSort(List<int> arr)
{

    int[] result = new int[100];

    for (int i = 0; i < arr.Count; i++)
    {
        result[arr[i]]++;
    }

    return result.ToList();
}