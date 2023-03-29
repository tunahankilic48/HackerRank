void miniMaxSum(List<int> arr)
{
    arr.Sort(); // Sort the array
    long sum = 0, maxSum = 0, minSum = 0;

    for (int i = 0; i < arr.Count; i++) // Find sum of the list
    {
        sum += arr[i];
    }

    maxSum = sum - arr[0]; // For max sum, first element shouldn't sum
    minSum = sum - arr[arr.Count - 1]; // For min sum, last element shouldn't sum

    Console.WriteLine(minSum + " " + maxSum);


}