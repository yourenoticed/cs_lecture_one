void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write(array[i] + " ");
        }
        else Console.WriteLine(array[i]);
    }
}

int IndexOf(int[] array, int sought)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == sought) return i;
    }
    return -1;
}

int[] list = new int[15];
FillArray(list, 1, 100);
PrintArray(list);
Console.WriteLine(IndexOf(list, 4));