string[] InitialArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter {i + 1} word: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] NewArray(string[] array, int size)
{
    int j = 0;
    string[] finalArray = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            finalArray[j] = array[i];
            j++;
        }
    }
    return finalArray;
}

Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] initArray = InitialArray(size);
ShowArray(initArray);
ShowArray(NewArray(initArray, size));

