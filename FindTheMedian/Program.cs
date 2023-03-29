int findMedian(List<int> arr) // It is only for odd length
{

    arr.Sort();

    decimal median = Math.Ceiling((decimal)arr.Count / 2);

    return arr[(int)median - 1];

}