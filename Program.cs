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

