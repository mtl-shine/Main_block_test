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