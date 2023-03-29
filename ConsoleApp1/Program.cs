string gridChallenge(List<string> grid)
{
    List<char[]> charsGrid = new List<char[]>();

    foreach (var item in grid)
    {
        char[] charArray = item.ToCharArray();
        Array.Sort(charArray);
        charsGrid.Add(charArray);
    }

    List<List<char>> tempChar = new List<List<char>>();
    for (int i = 0; i < charsGrid[0].Length; i++)
    {
        tempChar.Add(new List<char>());
    }
    for (int i = 0; i < charsGrid.Count; i++)
    {

        for (int j = 0; j < charsGrid[i].Length; j++)
        {
            tempChar[j].Add(charsGrid[i][j]);
        }
    }
    List<List<char>> temp2Char = new List<List<char>>();
    foreach (var item in tempChar)
    {
        temp2Char.Add(new List<char>(item));
    }

    for (int i = 0; i < tempChar.Count; i++)
    {
        temp2Char[i].Sort();
        for (int j = 0; j < tempChar[i].Count; j++)
        {
            if (tempChar[i][j] == temp2Char[i][j])
            {
                continue;
            }
            else
            {
                return "NO";
            }

        }
    }

    return "YES";
}

List<string> Grid = new List<string>() { "abc", "def", "xyz" };

Console.WriteLine(gridChallenge(Grid));