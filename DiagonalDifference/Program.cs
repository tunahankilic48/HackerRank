int diagonalDifference(List<List<int>> arr)
{
    int leftDiagonal = 0;
    int rightDiagonal = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        leftDiagonal += arr[i][i];
        rightDiagonal += arr[i][arr.Count - 1 - i];
    }


    return Math.Abs(leftDiagonal - rightDiagonal);
}