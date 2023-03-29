string timeConversion(string s)
{
    string[] arr = s.Split(':'); // input were splited acording to ':'. For example: 12:12:12PM, splitted as {12, 12, 12PM}

    int hour = int.Parse(arr[0]); // hours were detected


    if (hour == 12) // It is necessary for 12 hour special conditon that indicated in the question.
    {
        if (arr[2].Contains("PM"))
        {
            arr[0] = hour.ToString();
        }
        else
        {
            arr[0] = "00";
        }
            arr[2] = arr[2].Substring(0, 2);
            return String.Join(":", arr);
    }


    if (arr[2].Contains("PM")) // for conversion of the 24 hours format
    {
        hour += 12;
        if (hour >= 24)
        {
            hour -= 24;
        }
    }

    arr[2] = arr[2].Substring(0, 2); // to erase pm or am words


    if(hour < 10) // If we don't use this code snip, for input '06:06:06AM', output will be '6:06:06' but it must be '06:06:06'
    {
        arr[0] = "0" + hour.ToString();
    }
    else
        arr[0] =hour.ToString();


    return String.Join(":", arr); // for joining again
}

Console.WriteLine(timeConversion("06:40:03AM"));