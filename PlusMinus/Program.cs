void plusMinus(List<int> arr)
{
    int positiveCounts = 0, negativeCounts = 0, zeroCounts = 0; // Variables were created for keeping count of the positive, negative and zero numbers.

    foreach (int num in arr) // Loop were used to find out how many positive, negative and zero numbers in the list.
    {
        if (num > 0)
        {
            positiveCounts++;
        }
        else if (num < 0)
        {
            negativeCounts++;
        }
        else
        {
            zeroCounts++;
        }
    }

    decimal positiveCountRatio = (decimal)positiveCounts / arr.Count; // Ratios (positiveNumbers/Length of the list) were calculated
    decimal negativeCountRatio = (decimal)negativeCounts / arr.Count;
    decimal zeroCountRatio = (decimal)zeroCounts / arr.Count;

    Console.WriteLine(String.Format("{0:0.000000}", positiveCountRatio)); // Formatting was done for #.######
    Console.WriteLine(String.Format("{0:0.000000}", negativeCountRatio));
    Console.WriteLine(String.Format("{0:0.000000}", zeroCountRatio));
}
