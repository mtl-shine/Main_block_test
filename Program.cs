Console.Clear();
string[] EnterArrayFromConsole()
{
    Console.Write("Please enter a size of array: ");
    string[] array = new string[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Please, enter the element of array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int CalculateResultArraySize(string[] array, int limit)
{
    int i = 0;
    int j = 0;
    while (i < array.Length)
    {
        if (array[i].Length > limit)
        {
            i++;
        }
        else
        {
            j++;
            i++;
        }
    }
    return j;
}

string[] GetResultArray(string[] array, int limit, int size)
{
    string[] resultArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

string[] originArray = EnterArrayFromConsole();
int arraySize = CalculateResultArraySize(originArray, 3);
Console.Write($"[{String.Join(", ", GetResultArray(originArray, 3, arraySize))}]");
