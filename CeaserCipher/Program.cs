string caesarCipher(string s, int k)
{
    string originalAlphabetLowerCase = "abcdefghijklmnopqrstuvwxyz";
    string originalAlphabetUpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string encryptedMessage = "";
    int key = k % originalAlphabetLowerCase.Length;

    for (int i = 0; i < s.Length; i++)
    {
        int indexLower = originalAlphabetLowerCase.IndexOf(s[i]);
        int indexUpper = originalAlphabetUpperCase.IndexOf(s[i]);
        if (indexLower != -1)
        {
            encryptedMessage += (indexLower + key >= originalAlphabetLowerCase.Length) ? (originalAlphabetLowerCase[indexLower + key - originalAlphabetLowerCase.Length]) : (originalAlphabetLowerCase[indexLower + key]);

        }
        else if (indexUpper != -1)
        {
            encryptedMessage += (indexUpper + key >= originalAlphabetUpperCase.Length) ? (originalAlphabetUpperCase[indexUpper + key - originalAlphabetUpperCase.Length]) : (originalAlphabetUpperCase[indexUpper + key]);

        }
        else
        {
            encryptedMessage += s[i];
        }
    }
    return encryptedMessage;
}

